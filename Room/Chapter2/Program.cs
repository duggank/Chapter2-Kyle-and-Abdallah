using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, area;
            length = 15;
            width = 25;
            area = length * width;
            Console.WriteLine("If length is {0}ft and width is {1}ft, then area is {2} square ft.", length, width, area);
        }
    }
}
