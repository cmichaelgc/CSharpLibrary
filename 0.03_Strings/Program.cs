using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Demo
            string firstName;
            string lastName;
            string occupation;

            firstName = "Charles";
            lastName = "Michael";
            occupation = "looking";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //string interpolation
            Console.WriteLine("Name : {0}" + "\n" + "Occupation: {1}", fullName, occupation);

            Console.ReadLine();
        }
    }
}
