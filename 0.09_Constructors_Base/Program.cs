using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Base
{
    class Program
    {
        static void Main(string[] args)
        {

            Person kenn = new Person();
            kenn.FirstName = "kenn";
            kenn.LastName = "Pascascio";
            kenn.Age = 40;
            kenn.TestMethod();

            Person james = new Person("James", "Handshoe", 36);
            Person kenn2 = new Person("Kenny", "Pascascio", 45);
            kenn2.TestMethod();

            Minor lilly = new Minor("Lilly", "Michael", 3, false);

            Person jenn = new Minor("Jenn", "Aikins", 17, true);
            jenn.TestMethod();

            Console.ReadLine();
        }
    }
}
