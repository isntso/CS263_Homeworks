using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class StudentDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * .8;
        }

        public override string ToString()
        {
            return "學生證8折優惠";
        }
    }
}