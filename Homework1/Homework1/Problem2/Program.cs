using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student someone =
                new Student
                {
                    name = "老張",
                    contact = new Contact
                    {
                        email = "resnick1223@gmail.com",
                        phone = "0910123457"
                    }
                };

            Console.WriteLine(someone.name);
            Console.WriteLine(someone.contact.email);
            Console.WriteLine(someone.contact.phone);
        }
    }
}