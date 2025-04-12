using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore;
using static System.Reflection.Metadata.BlobBuilder;


namespace BookStore
{
    public class SearchBook
    {
        public Category Category1 { get; set; }
        public Category Category2 { get; set; }
        public Category Category3 { get; set; }

        public List<Book> Books { get; set; }

        public SearchBook()
        {
            Category1 = new Category("Programming");
            Category2 = new Category("AI");
            Category3 = new Category("Roman");

            Books = new List<Book>
        {
            new Book("C# Programming", "John Doe", 29.99m, Category1),
            new Book("Learning ASP.NET", "Jane Smith", 39.99m, Category2),
            new Book("A Christmas Carol", "Charles Dickens", 90.99m, Category2),
            new Book("A Tale of Two Cities", "Charles Dickens", 50.99m, Category3),
            new Book("Beyond Good and Evil", "Friedrich Nietzsche", 20.99m, Category3),
            new Book("Crime and Punishment", "Fyodor Dostoyevsky", 30.99m, Category3),
            new Book("David Copperfield", "Charles Dickens", 80.99m, Category3),
            new Book("Around the World in 80 Days", "Jules Verne", 70.99m, Category3),
            new Book("Alice’s Adventures in Wonderland", "Lewis Carroll", 60.99m, Category3),
            new Book("Agnes Grey", "Anne Brontë", 70.99m, Category3)
        };
        }

        public void Search()
        {

            Console.WriteLine("What book are you looking for?");
            string searchBook = Console.ReadLine();


            var selectedBooks = Books
                .Where(p => p.Title.Contains(searchBook, StringComparison.OrdinalIgnoreCase)).ToList();


            if (selectedBooks.Any())
            {
                foreach (var book in selectedBooks)
                {
                    Console.WriteLine($"You Find your book =>> Title: {book.Title}, Author: {book.Author}, Price: {book.Price:C}, Category: {book.Category.Title}");
                }
            }
            else
            {
                Console.WriteLine("No books found matching your search.");
            }
        }
    }
}
