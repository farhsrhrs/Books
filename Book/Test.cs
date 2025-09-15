using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Book;
//using Book.Models;
using Book.Services;

namespace Book
{
    public partial class Test : Form
    {
        private readonly BookService bookService;
        private List<Genre> genres;

        public Test()
        {
            InitializeComponent();
            bookService = new BookService("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=books");

            InitializeDataGrid();
            LoadGenres();
            InitializeCriteria();
            UpdateList();
        }
        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            // Проверяем, что перетаскивается файл
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                // Проверяем, что это изображение по расширению
                if (files.Length > 0 &&
                    (files[0].EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                     files[0].EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                     files[0].EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(files[0]);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // подогнать под размер
            }
        }

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

        private void LoadGenres()
        {
            comboGenre.Items.Clear();
            genres = bookService.GetGenres();
            foreach (var g in genres)
                comboGenre.Items.Add(g);

            if (comboGenre.Items.Count > 0)
                comboGenre.SelectedIndex = 0;
        }

        private void InitializeCriteria()
        {
            comboCriteria.Items.Clear();
            comboCriteria.Items.AddRange(new object[] { "Название", "Автор", "Год", "Жанр" });
            comboCriteria.SelectedIndex = 0;
        }

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

            var genre = (Genre)comboGenre.SelectedItem;
            bookService.AddBook(txtTitle.Text, txtAuthor.Text, year, genre.Id);

            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            comboGenre.SelectedIndex = 0;

            UpdateList();
        }

        private void btnRemoveById_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRemoveId.Text, out int id))
            {
                MessageBox.Show("Введите корректный ID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bookService.RemoveBook(id))
                MessageBox.Show("Книга удалена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Книга с таким ID не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txtRemoveId.Clear();
            UpdateList();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string criteria = comboCriteria.SelectedItem?.ToString();
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query)) return;

            var books = bookService.SearchBooks(criteria, query);
            FillDataGrid(books);
        }

        private void UpdateList()
        {
            var books = bookService.GetAllBooks();
            FillDataGrid(books);
        }

        private void FillDataGrid(List<Book> books)
        {
            dgvBooks.Rows.Clear();
            foreach (var book in books)
                dgvBooks.Rows.Add(book.Id, book.Title, book.Author, book.Year, book.GenreName);
        }
    }
}
