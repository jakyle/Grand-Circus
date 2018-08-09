using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1;
            DateTime date2;

            Console.WriteLine("Enter the first date in dd/mm/yyyy format");
            date1 = Convert.ToDateTime(Console.ReadLine()).Date;

            Console.WriteLine("Enter the second date in dd/mm/yyyy format");
            date2 = Convert.ToDateTime(Console.ReadLine()).Date;

            TimeSpan difference = date2.Subtract(date1);

            Console.WriteLine("Difference in Days---->" + difference.Days);
            Console.WriteLine("Difference in Hours---->" + (difference.Days * 24));
            Console.WriteLine("Difference in Minutes---->" + ((difference.Days * 24) * 60));

            Console.ReadKey();

        }

    }
}
