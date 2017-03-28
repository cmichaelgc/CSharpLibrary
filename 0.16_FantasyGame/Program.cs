using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
           // talkingConsole.Speak("What is your name?");
            Console.WriteLine("What is your name?");
                string name = Console.ReadLine();

            Console.WriteLine("What Clan do you align with?");
            //talkingConsole.Speak("What Clan do you align with?");
            string clan = Console.ReadLine();

            Console.WriteLine("What type of Player are you?\n" +
                                "0: Assassin\n" +
                                "1: Blitzen Blooper\n" +
                                "2: Professor\n" +
                                "3: Horse Mange\n" +
                                "4: Tax man\n" +
                                "5: Human\n");
            int playerType = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose your Weapon!\n" +
                               "0: Machette\n" +
                               "1: Moose Antlers\n" +
                               "2: Machine Gun\n" +
                               "3: Chunk of Wood\n" +
                               "4: Sling Shot\n");
            int weaponType = int.Parse(Console.ReadLine());

            Console.WriteLine("=============================");

            Player player = new Player(name, clan);
            player.ChooseType(playerType);
            player.ChooseWeapon(weaponType);

            Console.WriteLine("==========================================");
            Console.WriteLine("Player walkes through the woods to meet the first enemy of the day....\n\nIt is Scott!!! Be careful, Scott is a big DICK!!!");
            Console.WriteLine("Scott sees {0} and says,",player);
            Scott scott = new Scott();
            scott.Insult();


            Console.WriteLine("=========================================");
            while (true)
            {
                Console.WriteLine("Do you want to fight? y/n");
                string userAnswer = Console.ReadLine();
                Console.WriteLine("=================================");
                if (userAnswer == "y")
                {
                    player.BattleCry();
                    scott.ScottAttack(player);
                    if (player.CurrentPower <= 0)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
            Console.WriteLine("=================================");

            Console.WriteLine(player.CurrentPower);

            Console.WriteLine("=============================");
            Console.WriteLine("This is a new attack\n");
            scott.ScottAttack(player);


            Console.ReadLine();
        }
    }
}
