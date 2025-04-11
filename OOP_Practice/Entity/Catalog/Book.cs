using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }

    public Book (string title, string author, decimal price, Category category)
    {
        Title = title;
        Author = author;
        Price = price;
        Category = category;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} - ${Price}   in Category of {Category}";
    }
}
}