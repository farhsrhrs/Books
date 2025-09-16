using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Book.Services;
using OfficeOpenXml; // предполагается, что BookService и WarehouseService в этом namespace


namespace Book
{
    // Этот класс содержит всю логику работы формы — Test.cs будет вызывать только методы этого класса
    public class AppLogic
    {
        private readonly BookService _bookService;
        private readonly WarehouseService _warehouseService;

        public AppLogic(string connectionString)
        {
            _bookService = new BookService(connectionString);
            _warehouseService = new WarehouseService(connectionString);
        }
        public void ExportBooksToExcel(DataGridView dgvBooks, string filePath)
        {
            if (dgvBooks.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта!");
                return;
            }

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Книги");

                    // Заголовки
                    for (int i = 0; i < dgvBooks.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dgvBooks.Columns[i].HeaderText;
                    }

                    // Данные
                    for (int i = 0; i < dgvBooks.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvBooks.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dgvBooks.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Сохраняем файл
                    FileInfo fi = new FileInfo(filePath);
                    package.SaveAs(fi);
                }

                MessageBox.Show("Экспорт выполнен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте: " + ex.Message);
            }
        }
        public void LoadWarehousesToComboBox(ComboBox comboBox)
        {
            try
            {
                var whs = _warehouseService.GetAllWarehouses();
                comboBox.DataSource = null;
                comboBox.DataSource = whs;
                comboBox.DisplayMember = "Location";
                comboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке складов: " + ex.Message);
            }
        }

        public void LoadBooksIntoComboBox(ComboBox comboBox)
        {
            try
            {
                var books = _bookService.GetAllBooks();
                comboBox.DataSource = null;               // снимаем старую привязку
                comboBox.DataSource = books;              // привязываем новый список
                comboBox.DisplayMember = "Title";         // показываем название книги
                comboBox.ValueMember = "Id";              // используем Id для работы
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке книг в ComboBox: " + ex.Message);
            }
        }


        public List<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }

        public void SearchBooks(string criteria, string query, DataGridView dgv)
        {
            try
            {
                var allBooks = _bookService.GetAllBooks();
                List<Book> filtered = new List<Book>();

                switch (criteria)
                {
                    case "Название":
                        filtered = allBooks
                            .Where(b => b.Title.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                        break;

                    case "Автор":
                        filtered = allBooks
                            .Where(b => b.Author.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                        break;

                    case "Год":
                        if (int.TryParse(query, out int year))
                            filtered = allBooks.Where(b => b.Year == year).ToList();
                        break;

                    case "Жанр":
                        filtered = allBooks
                            .Where(b => b.GenreName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                        break;

                    case "Цена":
                        if (decimal.TryParse(query, out decimal price))
                        {
                            // точное совпадение
                            filtered = allBooks.Where(b => b.Price == price).ToList();
                        }
                        else
                        {
                            // если пользователь вводит "12" → найдём всё, что содержит "12"
                            filtered = allBooks
                                .Where(b => b.Price.ToString().Contains(query))
                                .ToList();
                        }
                        break;
                }

                dgv.Rows.Clear();
                foreach (var b in filtered)
                    dgv.Rows.Add(b.Id, b.Title, b.Author, b.Year,b.GenreName ,  b.Price);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске: " + ex.Message);
            }
        }


        // загрузка жанров в comboBox
        public void LoadGenres(ComboBox combo)
        {
            try
            {
                var genres = _bookService.GetAllGenres();
                combo.DataSource = genres;
                combo.DisplayMember = "Name"; // поле для отображения
                combo.ValueMember = "Id";     // ключ (ID жанра)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке жанров: " + ex.Message);
            }
        }

        // загрузка книг в comboBox
        public void LoadBooksCombo(ComboBox combo)
        {
            try
            {
                var books = _bookService.GetAllBooks();
                combo.DataSource = books;
                combo.DisplayMember = "Title"; // отображаем название
                combo.ValueMember = "Id";      // ключ (ID книги)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке книг: " + ex.Message);
            }
        }



        // --- Загрузить список книг в DataGridView ---
        public void LoadBooks(DataGridView dgv)
        {
            if (dgv == null) throw new ArgumentNullException(nameof(dgv));
            try
            {
                var books = _bookService.GetAllBooks();
                dgv.Rows.Clear();
                foreach (var b in books)
                {
                    dgv.Rows.Add(b.Id, b.Title, b.Author, b.Year, b.GenreName,b.Price);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке книг: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Загрузить книги в ComboBox (для выбора при создании склада) ---
        public void LoadBooksToCombo(ComboBox combo)
        {
            if (combo == null) throw new ArgumentNullException(nameof(combo));
            try
            {
                combo.Items.Clear();
                var books = _bookService.GetAllBooks();
                foreach (var b in books)
                    combo.Items.Add(b); // важно, чтобы Book.ToString() возвращал Title
                if (combo.Items.Count > 0) combo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка книг: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- Добавить книгу (параметры передаём контролы формы, чтобы логика могла читать/очищать их) ---
        public void AddBook(TextBox txtTitle, TextBox txtAuthor, TextBox txtYear, ComboBox comboGenre, DataGridView dgvBooks,TextBox textBoxPrice, ComboBox comboBooksForWarehouse = null )
        {
            try
            {
                if (txtTitle == null || txtAuthor == null || txtYear == null || comboGenre == null)
                    throw new ArgumentNullException("Неверные параметры.");

                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                if (!decimal.TryParse(textBoxPrice.Text.Trim(), out decimal price))
                {
                    MessageBox.Show("Введите корректную цену.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // price теперь содержит корректное decimal значение

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                {
                    MessageBox.Show("Название и автор обязательны.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtYear.Text.Trim(), out int year))
                {
                    MessageBox.Show("Некорректный год.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!(comboGenre.SelectedItem is Genre genre))
                {
                    MessageBox.Show("Выберите жанр.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _bookService.AddBook(title, author, year, genre.Id, price);

                // обновляем таблицу и, при необходимости, выпадающий список книг
                LoadBooks(dgvBooks);
                if (comboBooksForWarehouse != null) LoadBooksToCombo(comboBooksForWarehouse);

                // очистка полей
                txtTitle.Clear();
                txtAuthor.Clear();
                txtYear.Clear();
                textBoxPrice.Clear();

                MessageBox.Show("Книга добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Удалить книгу по id ---
        public void RemoveBook(TextBox txtRemoveId, DataGridView dgvBooks, ComboBox comboBooksForWarehouse = null)
        {
            try
            {
                if (!int.TryParse(txtRemoveId.Text.Trim(), out int id))
                {
                    MessageBox.Show("Введите корректный ID.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool removed = _bookService.RemoveBook(id);
                if (removed)
                {
                    LoadBooks(dgvBooks);
                    if (comboBooksForWarehouse != null) LoadBooksToCombo(comboBooksForWarehouse);
                    MessageBox.Show("Книга удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Книга с таким ID не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Загрузка складов ---
        public void LoadWarehouses(DataGridView dgv)
        {
            if (dgv == null) throw new ArgumentNullException(nameof(dgv));
            try
            {
                var whs = _warehouseService.GetAllWarehouses();
                dgv.Rows.Clear();
                foreach (var w in whs)
                    dgv.Rows.Add(w.Id, w.Location, w.Book_id, w.Quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке складов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Добавить склад (в comboBook передаётся ComboBox с объектами Book) ---
        public void AddWarehouse(TextBox txtLocation, ComboBox comboBook, TextBox txtQuantity, DataGridView dgv)
        {
            try
            {
                string location = txtLocation?.Text?.Trim();
                if (string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Введите местоположение склада.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!(comboBook?.SelectedItem is Book book))
                {
                    MessageBox.Show("Выберите книгу (из списка).", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtQuantity?.Text?.Trim(), out int qty) || qty < 0)
                {
                    MessageBox.Show("Некорректное количество.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _warehouseService.AddWarehouse(location, book.Id, qty);
                LoadWarehouses(dgv);

                txtLocation.Clear();
                txtQuantity.Clear();

                MessageBox.Show("Склад добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении склада: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Удалить склад ---
        public void RemoveWarehouse(TextBox txtRemoveId, DataGridView dgv)
        {
            try
            {
                if (!int.TryParse(txtRemoveId.Text.Trim(), out int id))
                {
                    MessageBox.Show("Введите корректный ID склада.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool removed = _warehouseService.RemoveWarehouse(id);
                if (removed)
                {
                    LoadWarehouses(dgv);
                    MessageBox.Show("Склад удалён.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Склад с таким ID не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении склада: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
