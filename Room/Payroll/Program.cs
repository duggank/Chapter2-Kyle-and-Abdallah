using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, SSN, input;
            double hpr, hours, gross, fed, state, net;

            Console.Write("Enter your name here: ");
            name = Console.ReadLine();
            
            Console.Write("Enter your Social Security number: ");
            SSN = Console.ReadLine();

            Console.Write("Hourly pay rate: ");
            input = Console.ReadLine();
            hpr = Convert.ToDouble(input);

            Console.Write("Hours worked: ");
            input = Console.ReadLine();
            hours = Convert.ToDouble(input);

            Console.WriteLine("Payroll Summary for: {0}", name);
            Console.WriteLine("SSN: {0}", SSN);
            Console.WriteLine("You earned ${0} at ${1} per hour", hours, hpr);

            gross = hpr * hours;
            Console.WriteLine("Gross pay:                  {0}", gross.ToString("C"));

            fed = gross * .15;
            Console.WriteLine("Federal withholding         {0}", fed.ToString("C"));

            state = gross * .05;
            Console.WriteLine("State withholding:          {0}", state.ToString("C"));
            Console.WriteLine("_____________________________________");

            net = gross - (state + fed);
            Console.WriteLine("Net pay:                    {0}", net.ToString("C"));

        }
    }
}
