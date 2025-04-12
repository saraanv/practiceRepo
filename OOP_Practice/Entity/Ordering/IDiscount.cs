using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initial.Entity.Ordering
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal total);
    }
}
