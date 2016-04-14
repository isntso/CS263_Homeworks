using DiscountLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket
{
    public class MovieTicket
    {
        private IDiscount discount;

        public MovieTicket()
        {
            this.price = 250;
        }

        private double price;

        public double Price
        {
            get
            {
                if (this.discount == null)
                    return this.price;
                else
                    return discount.Calculate(this.price);
            }

            set
            {
                this.price = value;
            }
        }

        public void SetDiscount(Discount discount)
        {
            this.discount = discount;
        }
    }
}