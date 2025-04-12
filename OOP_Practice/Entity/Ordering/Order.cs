using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Order
    {
        public List<Book> Books { get; private set; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var book in Books)
            {
                total += book.price;
            }
            return total;
        }

        public override string ToString()
        {
            return $"Order total : {CalculateTotal()}";
        }

    }
}
