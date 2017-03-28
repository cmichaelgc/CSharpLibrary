using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
            Console.WriteLine("What Clan do you align with?");
            string clan = Console.ReadLine();
            Console.WriteLine("What type of Player are you?\n" +
                                "0: Assassin\n" +
                                "1: Blitzen Blooper\n" +
                                "2: Professor\n" +
                                "3: Horse Mange\n" +
                                "4: Tax man\n" +
                                "5: Human");
            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name, clan);
            player.ChooseType(playerType);

            Console.WriteLine(player.ToString());
            

            Enemy Quagga = new Enemy();
            Quagga.Insult();

            Console.ReadLine();
        }
    }
}
