using System;
using System.Windows.Forms;
using Book.Services;


namespace Book
{
    public class AppShoppingList
    {
        private readonly ShoppingListService _shoppingListService;
        private readonly BookService _bookService;
        private readonly WarehouseService _warehouseService;
        private readonly CompanyService _companyService;

        public void LoadShoppingList(DataGridView dgv)
        {
            if (dgv == null) throw new ArgumentNullException(nameof(dgv));

            try
            {
                // используем сервис
                var shoppingList = _shoppingListService.GetAllShoppingLists();
                dgv.Rows.Clear();
                dgv.Columns.Clear();

                dgv.Columns.Add("Id", "ID");
                dgv.Columns.Add("Quantity", "Количество");
                dgv.Columns.Add("Book", "Книга");
                dgv.Columns.Add("Warehouse", "Склад");
                dgv.Columns.Add("Company", "Компания");

                foreach (var item in shoppingList)
                {
                    string bookTitle = _bookService.GetBookById(item.BookId)?.Title ?? "";
                    string warehouseLocation = _warehouseService.GetWarehouseById(item.WarehouseId)?.Location ?? "";
                    string companyName = _companyService.GetCompanyById(item.CompanyId)?.Name ?? "";

                    dgv.Rows.Add(item.Id, item.Quantity, bookTitle, warehouseLocation, companyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке заказов: " + ex.Message);
            }
        }



        public AppShoppingList(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _shoppingListService = new ShoppingListService(connectionString);
            _bookService = new BookService(connectionString);
            _warehouseService = new WarehouseService(connectionString);
            _companyService = new CompanyService(connectionString);
        }

        // Загрузка компаний
        public void LoadCompaniesToComboBox(ComboBox combo)
        {
            if (combo == null) throw new ArgumentNullException(nameof(combo));

            try
            {
                var companies = _companyService.GetAllCompanies();
                combo.DataSource = null;
                combo.DataSource = companies;
                combo.DisplayMember = "Name"; // показываем название компании
                combo.ValueMember = "Id";     // используем Id
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке компаний: " + ex.Message);
            }
        }

        // Загрузка складов
        public void LoadWarehousesToComboBox(ComboBox combo)
        {
            if (combo == null) throw new ArgumentNullException(nameof(combo));

            try
            {
                var warehouses = _warehouseService.GetAllWarehouses();
                combo.DataSource = null;
                combo.DataSource = warehouses;
                combo.DisplayMember = "Location"; // показываем название склада
                combo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке складов: " + ex.Message);
            }
        }

        // Загрузка книг
        public void LoadBooksToComboBox(ComboBox combo)
        {
            if (combo == null) throw new ArgumentNullException(nameof(combo));

            try
            {
                var books = _bookService.GetAllBooks();
                combo.DataSource = null;
                combo.DataSource = books;
                combo.DisplayMember = "Title"; // показываем название книги
                combo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке книг: " + ex.Message);
            }
        }
        // Загрузка в DataGridView
        public void LoadShoppingLists(DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();
                dgv.Columns.Clear();

                dgv.Columns.Add("Id", "ID");
                dgv.Columns.Add("Quantity", "Количество");
                dgv.Columns.Add("BookId", "Книга");
                dgv.Columns.Add("WarehouseId", "Склад");
                dgv.Columns.Add("CompanyId", "Компания");

                var shoppingLists = _shoppingListService.GetAllShoppingLists();

                foreach (var item in shoppingLists)
                {
                    dgv.Rows.Add(item.Id, item.Quantity, item.BookId, item.WarehouseId, item.CompanyId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка покупок: " + ex.Message);
            }
        }

        // Добавление
        public void AddShoppingList(TextBox txtQuantity, ComboBox cbBook, ComboBox cbWarehouse, ComboBox cbCompany, DataGridView dgv)
        {
            try
            {
                if (int.TryParse(txtQuantity.Text, out int quantity) &&
                    cbBook.SelectedItem is Book book &&
                    cbWarehouse.SelectedItem is Warehouse warehouse &&
                    cbCompany.SelectedItem is Company company)
                {
                    _shoppingListService.AddShoppingList(quantity, book.Id, warehouse.Id, company.Id);
                    LoadShoppingLists(dgv);
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи: " + ex.Message);
            }
        }

        // Удаление
        public void RemoveShoppingList(TextBox txtId, DataGridView dgv)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    _shoppingListService.RemoveShoppingList(id);
                    LoadShoppingLists(dgv);
                }
                else
                {
                    MessageBox.Show("Введите корректный ID!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message);
            }
        }
    }
}
