public class WarehouseStock
{
    public int Id { get; set; }            // Уникальный идентификатор записи
    public int WarehouseId { get; set; }   // Идентификатор склада
    public int BookId { get; set; }        // Идентификатор книги
    public int Quantity { get; set; }      // Количество книг на складе

    // Конструктор для удобного создания объекта
    public WarehouseStock(int id, int warehouseId, int bookId, int quantity)
    {
        Id = id;
        WarehouseId = warehouseId;
        BookId = bookId;
        Quantity = quantity;
    }

    // Пустой конструктор
}
