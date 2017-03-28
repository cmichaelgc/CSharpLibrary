using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Scott : Enemy
    {
        public string bigCry { get; set; }
        public string weapon { get; set; }

        public override void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("I'm {0}, and I'm a dick! You are a {1}", this.Name, insult[r]);
        }


        public Scott()
        {
            this.PowerLevel = 40;
            this.Name = "Scott";
        }
    }
}
