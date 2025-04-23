using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount_Overload
{
    public class CalculateDiscount
    {
        public decimal CalculateDiscountAmount(decimal SubTotal, double DiscountRate)
        {
            return (decimal)DiscountRate * SubTotal;
        }

        public decimal CalculateDiscountAmount(decimal SubTotal, decimal DiscountAmount)
        {
            return SubTotal - DiscountAmount;
        }
    }
}
