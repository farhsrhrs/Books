using System;

namespace BookCollectionModule
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();

            // Добавляем книги
            manager.AddBook(new Book("Преступление и наказание", "Ф.М. Достоевский", 1866));
            manager.AddBook(new Book("Война и мир", "Л.Н. Толстой", 1869));
            manager.AddBook(new Book("Мастер и Маргарита", "М.А. Булгаков", 1967));

            // Вывод всех книг
            Console.WriteLine("Все книги:");
            manager.PrintAllBooks();

            // Поиск по автору
            Console.WriteLine("\nПоиск по автору 'Толстой':");
            var foundByAuthor = manager.FindBookByAuthor("Толстой");
            foundByAuthor.ForEach(b => Console.WriteLine(b));

            // Поиск по названию
            Console.WriteLine("\nПоиск по названию 'Мастер':");
            var foundByName = manager.FindBookByName("Мастер");
            foundByName.ForEach(b => Console.WriteLine(b));

            // Удаление книги
            if (foundByName.Count > 0)
            {
                Console.WriteLine("\nУдаляем книгу:");
                manager.RemoveBook(foundByName[0].Id);
            }

            // Вывод после удаления
            Console.WriteLine("\nПосле удаления:");
            manager.PrintAllBooks();
        }
    }
}
