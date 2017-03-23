using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone Charles = new MobilePhone("Apple", "iPhone7", "Charles");
            MobilePhone Steve = new MobilePhone("Apple", "iPhone6", "Steve");

            Charles.PrintToScreen();
            Steve.PrintToScreen();

            Console.ReadLine();

        }
    }
}
