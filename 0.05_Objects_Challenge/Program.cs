using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hillbillyInn = new Hotel();
            hillbillyInn.roomNumber = 10;
            hillbillyInn.numBeds = 40;
            hillbillyInn.IsAvailable = "Yes";
            hillbillyInn.Cost = 14.99M;

            Console.WriteLine("The cost of a room per night at the Hill Billy Inn is {0:C}.", hillbillyInn.Cost);
            Console.ReadLine();
        }
    }
}
