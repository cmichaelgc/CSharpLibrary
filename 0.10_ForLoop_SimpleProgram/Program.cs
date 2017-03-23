using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForLoop_SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your starting Number:");
            int startingNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter your ending Number:");
            int endingNum = Int32.Parse(Console.ReadLine());

            //use startingNum and endingNum to crate a for loop that will
            //add every nimber in between
            int sum = 0;
            for (int i = startingNum; i <= endingNum; i++)
            {
                sum += i;
            }
            Console.WriteLine("the sum of {0} and {1} is {2}", startingNum, endingNum, sum);
            Console.ReadLine();
        }
    }
}
