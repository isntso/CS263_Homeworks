using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte number0 = 254;
            byte x = 1;
            byte number1 = (byte)(number0 + x);
            byte number2 = (byte)(number1 + x);
            Console.WriteLine(number0);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
}