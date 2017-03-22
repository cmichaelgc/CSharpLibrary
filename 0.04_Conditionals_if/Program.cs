using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_if
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            /*
             * Comparison Operators
             * 
             * == isEqual to
             * >= GreaterThan or Equal to
             * <=
             * !=
             * >
             * <
             * /
            */

            if(isOn)
            {
                Console.WriteLine("The light is on.");
            }
            //Create a isAdmin bool write an if statement that says
            //if a user is a admin "Welcome to the site"

            //Using a comparison operator for "and" using the isAdmin, and a new bool for 
            //isLoggedIn crate an If statement that prints out "Your logged in! and your an Admin"


            bool isAdmin = true;

            if(isAdmin)
            {
                Console.WriteLine("Welcome to the site!");
            }
            if(!isAdmin)
            {
                Console.WriteLine("Hey you aren't an Admin");
            }
            bool isLoggedIn = true;
            if (isAdmin && isLoggedIn)
            {
                Console.WriteLine("You're Logged in as an Admin!");
            }
            Console.ReadLine();
        }
    }
}
