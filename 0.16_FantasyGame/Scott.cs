using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Scott : Enemy
    {
        
            Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Head-butt", 5 },
                {"Mallet", 5 },
                {"Poision Fangs", 35 },
                {"Sweep the Leg", 45 }
            };
        
        public string bigCry { get; set; }
        public string weapon { get; set; }

        public override void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("I'm {0}, and I'm a dick! You are a {1}!", this.Name, insult[r]);
        }


        public Scott()
        {
            this.PowerLevel = 40;
            this.Name = "Scott";
        }

        public void ScottAttack(Player p)
        {
            Attack(p, Attacks, this.Name);
        }
    }
}
