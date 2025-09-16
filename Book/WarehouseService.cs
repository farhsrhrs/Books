using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;

namespace Book
{
    public class WarehouseService
    {
        private readonly string _connectionString;

        public WarehouseService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Warehouse GetWarehouseById(int id)
        {
            return GetAllWarehouses().FirstOrDefault(w => w.Id == id);
        }

        // Получить все склады
        public List<Warehouse> GetAllWarehouses()
        {
            var warehouses = new List<Warehouse>();

            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT id, location, book_id, quantity FROM warehouse ORDER BY id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                warehouses.Add(new Warehouse(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2),
                                    reader.GetInt32(3)
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении складов: " + ex.Message);
            }

            return warehouses;
        }

        // Добавить склад
        public void AddWarehouse(string location, int bookId, int quantity)
        {
            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentException("Location не может быть пустым");

            if (quantity < 0)
                throw new ArgumentException("Quantity не может быть отрицательным");

            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO warehouse(location, book_id, quantity) VALUES (@loc, @book, @qty)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("loc", location);
                        cmd.Parameters.AddWithValue("book", bookId);
                        cmd.Parameters.AddWithValue("qty", quantity);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                            throw new Exception("Данные не были добавлены в базу");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении склада: " + ex.Message);
            }
        }

        // Удалить склад по Id
        public bool RemoveWarehouse(int id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM warehouse WHERE id=@id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при удалении склада: " + ex.Message);
            }
        }

        // Найти склады по книге
        public List<Warehouse> SearchByBookId(int bookId)
        {
            var warehouses = new List<Warehouse>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT id, location, book_id, quantity FROM warehouse WHERE book_id=@book";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("book", bookId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                warehouses.Add(new Warehouse(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2),
                                    reader.GetInt32(3)
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при поиске склада: " + ex.Message);
            }

            return warehouses;
        }
    }
}
