using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    abstract class Enemy
    {
        protected ArrayList insult = new ArrayList { "wimp", "turd", "newb", "nerd cakes", "turd lips", "buster" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }



        public virtual void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("Your Mother is not a nice person {0}!", insult[r]);
        }

        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;
            
            Console.WriteLine("{0} power is at {1}%", player.PlayerName, player.CurrentPower);
            Console.WriteLine("Enemy is attacking with {0} and deals {1}", attackName, attackVal);

            player.CurrentPower -= attackVal;

        }
    }

}
