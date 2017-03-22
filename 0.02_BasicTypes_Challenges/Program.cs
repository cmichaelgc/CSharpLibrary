using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Charles Michael");
            byte age;
            string me = "Charles";
            string dog;
            short birth = 1987;

            dog = "bruno";
            age = 30;

            Console.WriteLine(me + " was born in {0}" + ", and is now {1}" + ".", birth, age);
            Console.WriteLine(me + " has a dog, and his name is {0}.", dog);
            Console.ReadLine();



        }
    }
}
