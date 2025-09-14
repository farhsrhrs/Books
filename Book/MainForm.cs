using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookCollectionModule
{
    public partial class MainForm : Form
    {
        private BookManager manager = new BookManager();

        public MainForm()
        {
            InitializeComponent();

            // Привязка обработчиков
            btnAdd.Click += btnAdd_Click;
            btnFind.Click += btnFind_Click;
            btnShowAll.Click += btnShowAll_Click;

            // Настройка DataGridView
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Название",
                DataPropertyName = "Title",
                Width = 150
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Автор",
                DataPropertyName = "Author",
                Width = 120
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Год",
                DataPropertyName = "Year",
                Width = 60
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Жанр",
                DataPropertyName = "Genre",
                Width = 100
            });

            // Заполнить начальный список
            UpdateList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Проверка данных
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                comboGenre.SelectedIndex < 0 || // проверка выбранного жанра
                !int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Введите корректные данные и выберите жанр!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем и добавляем книгу
            Book newBook = new Book(txtTitle.Text, txtAuthor.Text, year, comboGenre.SelectedItem.ToString());
            manager.AddBook(newBook);

            // Обновляем таблицу
            UpdateList();

            // Очистка полей
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            comboGenre.SelectedIndex = -1; // сброс ComboBox
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
                return;

            string criteria = comboCriteria.SelectedItem?.ToString();
            List<Book> found = new List<Book>();

            switch (criteria)
            {
                case "Название":
                    found = manager.FindBookByName(query);
                    break;
                case "Автор":
                    found = manager.FindBookByAuthor(query);
                    break;
                case "Год":
                    if (int.TryParse(query, out int year))
                        found = manager.GetAllBooks().Where(b => b.Year == year).ToList();
                    break;
                case "Жанр":
                    found = manager.GetAllBooks()
                        .Where(b => b.Genre.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                    break;
            }

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = found;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = manager.GetAllBooks();
        }
    }

}
