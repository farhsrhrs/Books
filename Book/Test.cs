using Npgsql;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book
{
    public partial class Test : Form
    {
        private readonly AppLogic _logic;
        private AppCompany _appCompany;
        private readonly AppShoppingList _appShoppingList;
        private  WarehouseService _warehouseService;
        private WarehouseStockService _warehouseStockSerive;
        
        public Test()
        {
            InitializeComponent();

            _logic = new AppLogic("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=books");

            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=books";
            
            _appCompany = new AppCompany(connStr); // теперь _connectionString инициализирован
            _appShoppingList = new AppShoppingList(connStr);
            _warehouseService = new WarehouseService(connStr);
            _warehouseStockSerive = new WarehouseStockService(connStr);

            _appShoppingList.LoadShoppingLists(dgvShopping);

            // инициализация DataGridView
            InitializeDataGridBooks();
            InitializeDataGridWarehouses();
            InitializeDataGridCompanies();
            InitializeWarehouseStockService();

            // загрузка данных в таблицы
            _logic.LoadBooks(dgvBooks);
            _logic.LoadWarehouses(dgvWarehouses);
            
            // загрузка жанров в comboGenre
            _logic.LoadGenres(comboGenre);

            // загрузка книг для склада
            _logic.LoadBooksCombo(comboNameBook);
            _warehouseService.LoadWarehouseNames(comboBoxWarehouse);
            // подписка на кнопки
            btnAdd.Click += btnAddBook_Click;
            btnRemoveById.Click += btnRemoveBook_Click;
            buttonAddWarehouse.Click += btnAddWarehouse_Click;
            
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            btnExport.Click += btnExport_Click;

            buttonAddCompany.Click += buttonAddCompany_Click;
            btnAddShopping.Click += btnAddShopping_Click;
            btnShowAll.Click += btnShowAll_Click; //подписка на кнопку все книги
            
            //this.btnReloadShopping.Click += new System.EventHandler(this.btnReloadShopping_Click);

            _appCompany.EnableDragDrop(pictureBox1);

            // Загрузка компаний в dgv
            _appCompany.LoadCompanies(dgvCompanies);


            // Загрузка данных в comboBox
            _appShoppingList.LoadCompaniesToComboBox(comboCompany);
            _appShoppingList.LoadWarehousesToComboBox(comboWarehouse);
            _appShoppingList.LoadBooksToComboBox(comboBook);

            // Загружаем текущий список заказов в DataGridView
            _appShoppingList.LoadShoppingList(dgvShopping);
            _warehouseStockSerive.GetAllStock();
            btnAddWarehouseStock.Click += btnAddWarehouseStock_Click;

        }
        private void btnAddWarehouseStock_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Проверка выбранного склада по имени
                if (comboBoxWarehouse.SelectedItem == null)
                {
                    MessageBox.Show("Выберите склад!");
                    return;
                }
                string warehouseName = comboBoxWarehouse.SelectedItem.ToString();

                int warehouseId;
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=books"))
                {
                    conn.Open();
                    string sql = "SELECT id FROM warehouse WHERE name = @name";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("name", warehouseName);
                        var result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Склад не найден в базе!");
                            return;
                        }
                        warehouseId = Convert.ToInt32(result);
                    }
                }

                // 2️⃣ Проверка выбранной книги по названию
                if (comboNameBook.SelectedItem == null)
                {
                    MessageBox.Show("Выберите книгу!");
                    return;
                }
                Book selectedBook = (Book)comboNameBook.SelectedItem;
                string bookTitle = selectedBook.Title;

                int bookId;
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=books"))
                {
                    conn.Open();
                    string sql = "SELECT id FROM book WHERE title = @title";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("title", bookTitle);
                        var result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Книга не найдена в базе!");
                            return;
                        }
                        bookId = Convert.ToInt32(result);
                    }
                }

                // 3️⃣ Проверка количества
                string qtyText = textQuantity.Text.Trim();

                if (string.IsNullOrEmpty(qtyText))
                {
                    MessageBox.Show("Введите количество!");
                    return;
                }

                if (!int.TryParse(qtyText, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Количество должно быть положительным целым числом!");
                    return;
                }


                // 4️⃣ Добавляем запись на склад
                _warehouseStockSerive.AddStock(warehouseId, bookId, quantity);
                MessageBox.Show("Данные успешно добавлены на склад!");

                // 5️⃣ Обновляем DataGridView
                var stockList = _warehouseStockSerive.GetStockByWarehouse(warehouseId);
                dataGridViewWarehouseStock.Rows.Clear();
                foreach (var stock in stockList)
                {
                    dataGridViewWarehouseStock.Rows.Add(
                        stock.Id,
                        stock.WarehouseId,
                        stock.BookId,
                        stock.Quantity
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении на склад: " + ex.Message);
            }
        }
       
        



        private void btnAddShopping_Click(object sender, EventArgs e)
        {
            _appShoppingList.AddShoppingList(textQuantity, comboBook, comboWarehouse, comboCompany, dgvShopping);
        }

       // private void btnRemoveShopping_Click(object sender, EventArgs e)
       // {
       //     _appShoppingList.RemoveShoppingList(txtShoppingId, dgvShopping);
      //  }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            _appCompany.AddCompany(textBox1, textBox2, textBox3, pictureBox1, dgvCompanies);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = "Книги.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _logic.ExportBooksToExcel(dgvBooks, sfd.FileName);
                }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3) // вкладка "Добавить склад"
            {
                _logic.LoadBooksIntoComboBox(comboNameBook);
            }

        }
        private void InitializeWarehouseStockService()
        {
            dataGridViewWarehouseStock.Columns.Clear();
            dataGridViewWarehouseStock.Columns.Add("Id", "ID");
            dataGridViewWarehouseStock.Columns.Add("WarehouseId", "Склад");
            dataGridViewWarehouseStock.Columns.Add("BookId", "Книга");
            dataGridViewWarehouseStock.Columns.Add("Quantity", "Количество");

        }
        private void InitializeShoppingUI()
        {
            // Таблица
            dgvShopping.Columns.Clear();
            dgvShopping.Columns.Add("Id", "ID");
            dgvShopping.Columns.Add("Quantity", "Количество");
            dgvShopping.Columns.Add("BookId", "Книга");
            dgvShopping.Columns.Add("WarehouseId", "Склад");
            dgvShopping.Columns.Add("CompanyId", "Компания");
            dgvShopping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Загрузка данных в ComboBox
            _logic.LoadBooksToCombo(comboBook);
            _logic.LoadWarehousesToComboBox(comboWarehouse);
            _appCompany.LoadCompaniesToComboBox(comboCompany);
        }
        private void InitializeDataGridCompanies()
        {
            dgvCompanies.Columns.Clear();
            dgvCompanies.Columns.Add("ID", "ID");
            dgvCompanies.Columns.Add("Name", "Название");
            dgvCompanies.Columns.Add("Organization", "Организация");
            dgvCompanies.Columns.Add("Phone", "Телефон");
            dgvCompanies.Columns.Add("Logo", "Логотип");

            dgvCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompanies.MultiSelect = false;
            dgvCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void InitializeDataGridBooks()
        {
            dgvBooks.Columns.Clear();
            dgvBooks.Columns.Add("ID", "ID");
            dgvBooks.Columns.Add("Title", "Название");
            dgvBooks.Columns.Add("Author", "Автор");
            dgvBooks.Columns.Add("Year", "Год");
            dgvBooks.Columns.Add("Genre", "Жанр");
            dgvBooks.Columns.Add("Price", "Цена");
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitializeDataGridWarehouses()
        {
            dgvWarehouses.Columns.Clear();
            dgvWarehouses.Columns.Add("ID", "ID");
            dgvWarehouses.Columns.Add("Location", "Склад");
            dgvWarehouses.Columns.Add("name", "Название");

            dgvWarehouses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWarehouses.MultiSelect = false;
            dgvWarehouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            _logic.AddBook(txtTitle, txtAuthor, txtYear, comboGenre,dgvBooks, textBoxPrice );
        }


        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            _logic.RemoveBook(txtRemoveId, dgvBooks);
        }


        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            _logic.AddWarehouse(textLocation, textBoxNameWarehouse, dgvWarehouses);
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
