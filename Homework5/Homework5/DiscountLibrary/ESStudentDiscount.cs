using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class ESStudentDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * .7;
        }

        public override string ToString()
        {
            return "小學生7折優惠";
        }
    }
}