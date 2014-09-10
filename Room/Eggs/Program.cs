using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1, chicken2, chicken3, chicken4, total, dozens, eggs;
            int months = 3;
            chicken1 = 6 * months;
            chicken2 = 8 * months;
            chicken3 = 4 * months;
            chicken4 = 12 * months;
            total = chicken1 + chicken2 + chicken3 + chicken4;
            dozens = total / 12;
            eggs = total % 12;
            Console.WriteLine("There are {0} eggs in total, so that means there are {1} dozens and {2} eggs!", total, dozens, eggs);
        }
    }
}
