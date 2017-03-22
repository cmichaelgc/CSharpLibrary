using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if(feelingNumber == "5")
            {
                Console.WriteLine("Wow! That's great to hear.");
            }
            else if(feelingNumber == "4")
            {
                Console.WriteLine("Not too shabby.");
            }
            else if(feelingNumber == "3")
            {
                Console.WriteLine("Could feel better.");
            }
            else if(feelingNumber == "2")
            {
                Console.WriteLine("Why so blue?");
            }
            else if(feelingNumber == "1")
            {
                Console.WriteLine("Go home and take a nap....");
            }
            else
            {
                Console.WriteLine("You can't feel that good, Try again!");
            }
            Console.ReadLine();
        }
    }
}
