namespace Book
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int BookId { get; set; }
        public int WarehouseId { get; set; }
        public int CompanyId { get; set; }

        public ShoppingList(int id, int quantity, int bookId, int warehouseId, int companyId)
        {
            Id = id;
            Quantity = quantity;
            BookId = bookId;
            WarehouseId = warehouseId;
            CompanyId = companyId;
        }
    }
}
