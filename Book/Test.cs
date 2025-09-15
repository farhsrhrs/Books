using System;
using System.Windows.Forms;

namespace Book
{
    public partial class Test : Form
    {
        private readonly AppLogic _logic;

        public Test()
        {
            InitializeComponent();

            _logic = new AppLogic("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=books");

            // инициализация DataGridView
            InitializeDataGridBooks();
            InitializeDataGridWarehouses();

            // загрузка данных в таблицы
            _logic.LoadBooks(dgvBooks);
            _logic.LoadWarehouses(dgvWarehouses);

            // загрузка жанров в comboGenre
            _logic.LoadGenres(comboGenre);

            // загрузка книг для склада
            _logic.LoadBooksCombo(comboBoxNameBook);

            // подписка на кнопки
            btnAdd.Click += btnAddBook_Click;
            btnRemoveById.Click += btnRemoveBook_Click;
            buttonAddWarehouse.Click += btnAddWarehouse_Click;
            
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3) // вкладка "Добавить склад"
            {
                _logic.LoadBooksIntoComboBox(comboBoxNameBook);
            }
        }
        private void InitializeDataGridBooks()
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

        private void InitializeDataGridWarehouses()
        {
            dgvWarehouses.Columns.Clear();
            dgvWarehouses.Columns.Add("ID", "ID");
            dgvWarehouses.Columns.Add("Location", "Склад");
            dgvWarehouses.Columns.Add("BookId", "ID Книги");
            dgvWarehouses.Columns.Add("Quantity", "Кол-во");
            dgvWarehouses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWarehouses.MultiSelect = false;
            dgvWarehouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            _logic.AddBook(txtTitle, txtAuthor, txtYear, comboGenre, dgvBooks);
        }


        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            _logic.RemoveBook(txtRemoveId, dgvBooks);
        }


        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            _logic.AddWarehouse(textLocation, comboBoxNameBook, textQuantity, dgvWarehouses);
        }

        private void btnRemoveWarehouse_Click(object sender, EventArgs e)
        {
           // _logic.RemoveWarehouse(txtWarehouseRemoveId, dgvWarehouses);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string criteria = comboCriteria.SelectedItem?.ToString();
            string query = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(query))
                _logic.SearchBooks(criteria, query, dgvBooks);
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            _logic.LoadBooks(dgvBooks);
        }

    }
}
