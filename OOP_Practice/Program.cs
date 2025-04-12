using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BookStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("____Menu____");
            Console.WriteLine("1) Main Program By Sara");
            Console.WriteLine("2) Search A Book.");
            Console.WriteLine("Please enter your choice");

            var input = Console.ReadLine();

            if (input != null)
            {
                Console.Clear();
                var SelectedMenu = int.Parse(input);
                switch (SelectedMenu)
                {
                    case 1:
                        {
                            //Create Customer
                            Customer customer = new Customer("Alice" , "alice@gmail.com");
                            Console.WriteLine(customer);

                            //Create Category
                            Category Category1 = new Category("Programming");
                            Category Category2 = new Category("AI");
                            Category Category3 = new Category("Novel");

                            //Create Book
                            Book book1 = new Book("C# basics" , "John Doe" , 29.99m, Category1);\
                            Book book2 = new Book("Learning ASP.NET" , "Jane Smith", 39.99, Category2);

                            Console.WriteLine(book1);
                            Console.WriteLine(book2);

                            //Create Order
                            Order order = new Order();
                            order.AddBook(book1);
                            order.AddBook(book2);
                            Console.WriteLine(order);

                            //Dicsount (percentage)
                            IDiscount percentageDiscount = new PercentageDiscount(10);
                            decimal total = order.CalculateTotal();
                            ecimal discountedTotalPercentage = percentageDiscount.ApplyDiscount(total);
                            Console.WriteLine($"Total after percentage discount: ${discountedTotalPercentage}");

                            //Discount (fixed)
                            IDiscount fixedAmountDiscount = new FixedAmountDiscount(15); 
                            decimal discountedTotalFixedAmount = fixedAmountDiscount.ApplyDiscount(total);
                            Console.WriteLine($"Total after fixed amount discount: ${discountedTotalFixedAmount}");
                            break;
                        }
                    case 2:
                        {

                        }
                }
            }
            Console.WriteLine("Nothing");
            Console.WriteLine("Nothing2");
        }
    }
}