using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wenesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Before");
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            daysOfWeek[2] = "Wednesday";
             

            Console.WriteLine("\r\nAfter");
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }

    
    }
}
