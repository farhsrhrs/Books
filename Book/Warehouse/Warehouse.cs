namespace Book
{
    public class Warehouse
    {
        private static int _nextId = 1;

        public int Id { get; set; }
        public string Location { get; set; }

        public string Name { get; set; }
         // название жанра

        // Конструктор для режима без БД

        // Конструктор для загрузки из БД
        public Warehouse(int id, string location, string name)
        {
            Id = id;
            Location = location;
            Name = name;

        }
    }
}
