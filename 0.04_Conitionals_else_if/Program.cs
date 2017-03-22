using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.04Conditionals_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
        int bankAccount = 50000;
        int debt = 13500;
        int difference = bankAccount - debt;

        Console.WriteLine("I have {0} in my bank account, and I am {1 : C} in debt", bankAccount, debt);


        Console.ReadLine();
        }
    }
}
