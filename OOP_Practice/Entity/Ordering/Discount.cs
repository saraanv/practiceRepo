using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class PercentageDiscount : IDiscount
    {
        private decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return total - (total * _percentage / 100);
        }
    }

    public class FixedAmountDiscount : IDiscount
    {
        private decimal _FixedAmount;

        public PercentageDiscount(decimal fixedAmount)
        {
            _FixedAmount = fixedAmount;
        }

        public decimal ApplyDiscount(decimal total)
        {
            // Making sure that discount is not more than the total amount.
            return total - Math.Min (_FixedAmount, total);
        }
    }


}
