using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Inheritance
{
    class Fox : Animal
    {
        public bool Sly { get; set; }
        public string HasPuppies { get; set; }
        public string Preditor { get; set; }

        public void Cry()
        {
            Console.WriteLine("AHHHHHHHH!!!!!!!");
        }
        public void Eat()
        {
            Console.WriteLine("Crunch, Crunch, Crunch....");
        }
    }
}
