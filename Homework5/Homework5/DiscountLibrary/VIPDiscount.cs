using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class VIPDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * .5;
        }

        public override string ToString()
        {
            return "花旗卡5折優惠";
        }
    }
}