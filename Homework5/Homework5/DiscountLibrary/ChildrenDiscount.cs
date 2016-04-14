using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class ChildrenDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * .3;
        }

        public override string ToString()
        {
            return "10歲以下兒童3折優惠";
        }
    }
}