using Npgsql;
using System;
using System.Collections.Generic;

internal class WarehouseStockService
{
    private readonly string _connectionString;

    public WarehouseStockService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddStock(int warehouseId, int bookId, int quantity)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            conn.Open();

            string insertSql = "INSERT INTO warehouse_stock(id_warehouse, book_id, quantity) VALUES (@wid, @bid, @qty)";
            using (var cmd = new NpgsqlCommand(insertSql, conn))
            {
                cmd.Parameters.AddWithValue("wid", warehouseId);
                cmd.Parameters.AddWithValue("bid", bookId);
                cmd.Parameters.AddWithValue("qty", quantity);

                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    throw new Exception("Данные не были добавлены в базу");
                }
            }
        }
    }


    // 1️⃣ Получить все записи склада
    public List<WarehouseStock> GetAllStock()
    {
        var stockList = new List<WarehouseStock>();

        using (var conn = new NpgsqlConnection(_connectionString))
        {
            conn.Open();
            string sql = "SELECT id, id_warehouse, book_id, quantity FROM warehouse_stock ORDER BY id";
            using (var cmd = new NpgsqlCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    stockList.Add(new WarehouseStock(
                        reader.GetInt32(0),  // id
                        reader.GetInt32(1),  // id_warehouse
                        reader.GetInt32(2),  // book_id
                        reader.GetInt32(3)   // quantity
                    ));
                }
            }
        }

        return stockList;
    }

    // 2️⃣ Получить записи по конкретному складу
    public List<WarehouseStock> GetStockByWarehouse(int warehouseId)
    {
        var stockList = new List<WarehouseStock>();

        using (var conn = new NpgsqlConnection(_connectionString))
        {
            conn.Open();
            string sql = "SELECT id, id_warehouse, book_id, quantity FROM warehouse_stock WHERE id_warehouse = @wid ORDER BY id";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("wid", warehouseId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stockList.Add(new WarehouseStock(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3)
                        ));
                    }
                }
            }
        }

        return stockList;
    }

    // 3️⃣ Добавить новую запись или обновить количество, если уже есть
    

    // 4️⃣ Удалить запись со склада
    public void DeleteStock(int warehouseId, int bookId)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            conn.Open();
            string sql = "DELETE FROM warehouse_stock WHERE id_warehouse = @wid AND book_id = @bid";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("wid", warehouseId);
                cmd.Parameters.AddWithValue("bid", bookId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
