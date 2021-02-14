using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int iDay;
            Console.WriteLine("Which day would you like to display?");
           
           
            
            do
            {
                Console.WriteLine("(Monday = 1, etc.) > ");
                iDay = int.Parse(Console.ReadLine()) - 1;
            } while (iDay > daysOfWeek.Length);
            

            string chosenDay = daysOfWeek[iDay];
            Console.WriteLine($"That day is {chosenDay}");
        }
    }
}
