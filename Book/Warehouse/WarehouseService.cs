using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
                    string sql = "SELECT id, name, location FROM warehouse ORDER BY id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                warehouses.Add(new Warehouse(
                        reader.GetInt32(0),      // id
                        reader.GetString(1),     // name
                        reader.GetString(2)      // location

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
        public void AddWarehouse(string location,string name)
        {
            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentException("Location не может быть пустым");


            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO warehouse(location,name ) VALUES (@loc ,@nm )";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("loc", location);
                        cmd.Parameters.AddWithValue("nm", name);

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

        public void LoadWarehouseNames(ComboBox comboBox)
        {
            comboBox.Items.Clear(); // очищаем предыдущие элементы

            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = "SELECT name FROM warehouse ORDER BY name";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке складов: " + ex.Message);
            }
        }

        // Найти склады по книге


    }
}
