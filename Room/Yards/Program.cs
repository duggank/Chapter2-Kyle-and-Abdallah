using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, area;
            double money, yards, total;
            length = 25;
            width = 42;
            area = length * width;
            yards = area / 9;
            money = 5.30;
            total = money * yards;
            Console.WriteLine("if length is {0}ft and width is {1}ft, then area is {2} square ft.", length, width, area);
            Console.WriteLine("Let's convert the area into yards. So, we'd get {0} square yards. If you pay {1} per yard, then you'd pay {2} in total.", yards, money.ToString("C"), total.ToString("C"));
        }
    }
}
