using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            Bear barryTheBear = new Bear();
            barryTheBear.Weight = 2000;
            barryTheBear.Walks();
            barryTheBear.Speak();
            Console.WriteLine("=================================================");


            Fox foxyTheFox = new Fox();
            foxyTheFox.Weight = 60;
            foxyTheFox.Eat();
            foxyTheFox.Cry();

            //Animal theJSWiz = new Animal();
            //theJSWiz.NumberOfLegs = 2;
            

            Console.WriteLine("=================================================");

            Console.ReadLine();
        }
    }
}
