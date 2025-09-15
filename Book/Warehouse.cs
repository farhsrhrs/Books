namespace Book
{
    public class Warehouse
    {
        private static int _nextId = 1;

        public int Id { get; set; }
        public string Location { get; set; }
        public string Author { get; set; }
        public int Book_id { get; set; }
        public int Quantity { get; set; }       // id жанра
         // название жанра

        // Конструктор для режима без БД

        // Конструктор для загрузки из БД
        public Warehouse(int id, string location, int book_id, int quantity)
        {
            Id = id;
            Location = location;
            Book_id = book_id;
            Quantity = quantity;

        }
    }
}
