using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, hours, leftmin;
            min = 230;
            hours = min / 60;
            leftmin = min % 60;
            Console.WriteLine("{0} minutes = {1} hours and {2} minutes", min, hours, leftmin);
        }
    }
}
