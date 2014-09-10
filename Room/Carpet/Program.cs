using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, area, money, total;
            length = 10;
            width = 12;
            area = length * width;
            money = 13.56;
            total = money * area;

            Console.WriteLine("If length is {0}ft and width is {1}ft, then area is {2}square ft. So, if you have to pay {3} per square ft, then the cost of the total area would be {4}", length, width, area, money.ToString("C"), total.ToString("C"));
        }
    }
}
