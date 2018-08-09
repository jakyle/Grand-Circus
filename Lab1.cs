using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {


        public static void Main()
        {

            Console.Write("\n\n"); //begin user input
            Console.Write("Check whether each cooresponding digit in two intigers sum to the same number or not:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input 1st number then hit enter: ");
            string int1 = (Console.ReadLine());//user input 1


            Console.Write("Input 2nd number: ");
            string int2 = (Console.ReadLine());//user input 2

            int[] numbers = new int[int1.ToString().Length]; //changing user inputs to strings for array
            int[] numbers2 = new int[int2.ToString().Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(int1.Substring(i, 1));//populating arrays
                numbers2[i] = int.Parse(int2.Substring(i, 1));
            }


            int[] numbers3 = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers3[i] = (numbers[i] + numbers2[i]);
            }

            int sum1 = numbers.Aggregate(0, (acc, x) => acc + x);
            int sum2 = numbers2.Aggregate(0, (acc, x) => acc + x);
            if
                (sum1 == sum2)
                Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.ReadKey();
        }
                  
    }
    

    }








           




        

   

