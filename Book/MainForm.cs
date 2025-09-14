using System;
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
            var found = rbTitle.Checked
                ? manager.FindBookByName(txtSearch.Text)
                : manager.FindBookByAuthor(txtSearch.Text);

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
