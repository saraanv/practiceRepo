using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Category
    {
        public string Title { get; set; }

        public Category (string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
