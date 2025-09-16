using System.Collections.Generic;
using Npgsql;


namespace Book
{
    public class ShoppingListService
    {
        private readonly string _connectionString;

        public ShoppingListService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ShoppingList> GetAllShoppingLists()
        {
            var list = new List<ShoppingList>();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id, quantity, book_id, warehouse_id, company_id FROM shopping_list", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ShoppingList(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4)
                        ));
                    }
                }
            }

            return list;
        }

        public void AddShoppingList(int quantity, int bookId, int warehouseId, int companyId)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "INSERT INTO shopping_list (quantity, book_id, warehouse_id, company_id) VALUES (@q, @b, @w, @c)", conn))
                {
                    cmd.Parameters.AddWithValue("q", quantity);
                    cmd.Parameters.AddWithValue("b", bookId);
                    cmd.Parameters.AddWithValue("w", warehouseId);
                    cmd.Parameters.AddWithValue("c", companyId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoveShoppingList(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM shopping_list WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
