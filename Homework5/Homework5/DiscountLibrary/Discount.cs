using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class Discount : IDiscount
    {
        public virtual double Calculate(double price)
        {
            return price;
        }

        public override string ToString()
        {
            return "全票";
        }
    }
}