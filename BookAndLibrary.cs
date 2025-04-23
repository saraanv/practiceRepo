class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int ISBN { get; set; }
    public bool IsAvailable { get; set; }
}
class Library
{
    public List<Book> books = new List<Book>();
    public void AddBook(Book book)
        {
        books.Add(book);
        }
    public void BorrowBook(string input)
    {
        bool found  = false;

        foreach (Book book in books)
        {
            if (book.Title == input)
            {
                if (book.IsAvailable)
                {
                    book.IsAvailable = false;
                    Console.WriteLine($"Borrowed{book.Title}");
                }
                else
                {
                    Console.WriteLine("Already borrowed");
                }
                found = true;
                break;
            }
            if (!found)
            {
                Console.WriteLine("Book not found.");
            }
        }
    }

    public void ReturBook()
    {
        Console.WriteLine("Books In Library");
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Available: {book.IsAvailable}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.Title = "C#";
        book.Author = "Joseph Albahari";
        book.ISBN = 1234;
        book.IsAvailable = true;

        Book book1 = new Book();
        book1.Title = "C#1";
        book1.Author = "Joseph Albahari1";
        book1.ISBN = 12341;
        book1.IsAvailable = true;

        Library library = new Library();
        library.AddBook(book);
        library.AddBook(book1);

        Console.WriteLine("Search a book");
        string input = Console.ReadLine();
        library.BorrowBook(input);
        library.ReturBook();

    }
}