using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Enemy
    {
        public string Name { get; set; }
        public int PowerLevel { get; set; }


        public void Insult()
        {
            ArrayList insult = new ArrayList { "wimp", "turd", "newb", "nerd cakes", "turd lips", "buster" };
            insult.Add("four-eyes");
            Random rnd = new Random();
            int r = rnd.Next(0, insult.Count);

            Console.WriteLine("Your Mother is not a nice person {0}!", insult[r]);
        }
    }
}
