using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;


namespace BookCollectionModule
{
    public partial class MainForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=books";

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGrid();
            LoadGenres();
            InitializeCriteria();
            UpdateList();
        }

        // ---------------- DataGrid ----------------
        private void InitializeDataGrid()
        {
            dgvBooks.Columns.Clear();
            dgvBooks.Columns.Add("ID", "ID");
            dgvBooks.Columns.Add("Title", "Название");
            dgvBooks.Columns.Add("Author", "Автор");
            dgvBooks.Columns.Add("Year", "Год");
            dgvBooks.Columns.Add("Genre", "Жанр");

            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvBooks.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel файлы (*.xlsx)|*.xlsx",
                FileName = "Books.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Важно для EPPlus

                        using (var package = new ExcelPackage())
                        {
                            var ws = package.Workbook.Worksheets.Add("Книги");

                            // Заголовки
                            for (int i = 0; i < dgvBooks.Columns.Count; i++)
                            {
                                ws.Cells[1, i + 1].Value = dgvBooks.Columns[i].HeaderText;
                                ws.Cells[1, i + 1].Style.Font.Bold = true;
                                ws.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                ws.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                            }

                            // Данные
                            for (int r = 0; r < dgvBooks.Rows.Count; r++)
                            {
                                for (int c = 0; c < dgvBooks.Columns.Count; c++)
                                {
                                    ws.Cells[r + 2, c + 1].Value = dgvBooks.Rows[r].Cells[c].Value?.ToString();
                                }
                            }

                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            // Сохраняем
                            FileInfo fi = new FileInfo(sfd.FileName);
                            package.SaveAs(fi);
                        }

                        MessageBox.Show("Данные успешно экспортированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка экспорта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ---------------- ComboBox жанров ----------------
        private void LoadGenres()
        {
            comboGenre.Items.Clear();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id, name FROM genres ORDER BY name", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboGenre.Items.Add(new ComboBoxItem
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
            }
            if (comboGenre.Items.Count > 0)
                comboGenre.SelectedIndex = 0;
        }

        private void InitializeCriteria()
        {
            comboCriteria.Items.Clear();
            comboCriteria.Items.AddRange(new object[] { "Название", "Автор", "Год", "Жанр" });
            comboCriteria.SelectedIndex = 0;
        }

        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }

        // ---------------- Добавление ----------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                comboGenre.SelectedItem == null ||
                !int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Введите корректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var genreItem = (ComboBoxItem)comboGenre.SelectedItem;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "INSERT INTO books(title, author, year, genre_id) VALUES (@title,@author,@year,@genre)",
                    conn);
                cmd.Parameters.AddWithValue("title", txtTitle.Text);
                cmd.Parameters.AddWithValue("author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("year", year);
                cmd.Parameters.AddWithValue("genre", genreItem.Id);
                cmd.ExecuteNonQuery();
            }

            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            comboGenre.SelectedIndex = 0;

            UpdateList();
        }

        // ---------------- Удаление ----------------
        private void btnRemoveById_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRemoveId.Text, out int id))
            {
                MessageBox.Show("Введите корректный ID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM books WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("id", id);
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                    MessageBox.Show("Книга с таким ID не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtRemoveId.Clear();
            UpdateList();
        }

        // ---------------- Показать все ----------------
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        // ---------------- Поиск ----------------
        private void btnFind_Click(object sender, EventArgs e)
        {
            string criteria = comboCriteria.SelectedItem?.ToString();
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query)) return;

            List<Book> books = new List<Book>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT b.id, b.title, b.author, b.year, b.genre_id, g.name " +
                             "FROM books b JOIN genres g ON b.genre_id=g.id WHERE ";

                switch (criteria)
                {
                    case "Название": sql += "b.title ILIKE @q"; break;
                    case "Автор": sql += "b.author ILIKE @q"; break;
                    case "Год": sql += "b.year=@q"; break;
                    case "Жанр": sql += "g.name ILIKE @q"; break;
                    default: sql += "1=0"; break;
                }

                var cmd = new NpgsqlCommand(sql, conn);
                if (criteria == "Год")
                    cmd.Parameters.AddWithValue("q", int.Parse(query));
                else
                    cmd.Parameters.AddWithValue("q", "%" + query + "%");

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new Book(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetInt32(4),
                        reader.GetString(5)
                    ));
                }
            }

            dgvBooks.Rows.Clear();
            foreach (var book in books)
                dgvBooks.Rows.Add(book.Id, book.Title, book.Author, book.Year, book.GenreName);
        }

        // ---------------- Обновление списка ----------------
        private void UpdateList()
        {
            List<Book> books = new List<Book>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT b.id, b.title, b.author, b.year, b.genre_id, g.name " +
                    "FROM books b JOIN genres g ON b.genre_id=g.id ORDER BY b.id",
                    conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new Book(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetInt32(4),
                        reader.GetString(5)
                    ));
                }
            }

            dgvBooks.Rows.Clear();
            foreach (var book in books)
                dgvBooks.Rows.Add(book.Id, book.Title, book.Author, book.Year, book.GenreName);
        }
    }
}
