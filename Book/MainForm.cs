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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                !int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Введите корректные данные!");
                return;
            }

            manager.AddBook(new Book(txtTitle.Text, txtAuthor.Text, year));
            UpdateList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBooks.SelectedItem is Book selectedBook)
            {
                manager.RemoveBook(selectedBook.Id);
                UpdateList();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            listBooks.Items.Clear();
            var criteria = comboCriteria.SelectedItem.ToString();
            var query = txtSearch.Text.Trim();
            List<Book> found = new List<Book>();

            if (string.IsNullOrEmpty(query))
                return;

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
            }

            foreach (var book in found)
                listBooks.Items.Add(book);
        }


        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            listBooks.Items.Clear();
            foreach (var book in manager.GetAllBooks())
                listBooks.Items.Add(book);
        }

    }
}
