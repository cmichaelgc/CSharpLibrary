using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Kenn";

            switch (friend)
            {
                case "Fred":
                    Console.WriteLine("Hey Fred");
                    break;
                case "Kenn":
                    Console.WriteLine("Hey Kenn");
                    break;
                case "Jenn":
                    Console.WriteLine("Hey Jenn");
                    break;
                case "Steve":
                    Console.WriteLine("Hey Steve");
                    break;
                case "Kent":
                    Console.WriteLine("Hey Kent");
                    break;
                case "Bill":
                    Console.WriteLine("Hey Bill");
                    break;
                case "Dave":
                    Console.WriteLine("Hey Dave");
                    break;
                default:
                    Console.WriteLine("You hit the default.");
                    break;

            }
            Console.ReadLine();
        }
    }
}
