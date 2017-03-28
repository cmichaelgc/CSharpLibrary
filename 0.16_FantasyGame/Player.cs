using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    public enum CharacterType
    {
        Assassin = 0,
        BlitzenBlopper = 1,
        Professor = 2,
        HorseMange = 3,
        TaxMan = 4,
        Human = 5
    }
    class Player
    {
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }


        public Player(string name, string clanName, CharacterType type = CharacterType.HorseMange)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentPower = 100;
            this.Type = type;
        }
        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    Console.WriteLine("You are an Assassin!");
                    return this.Type = CharacterType.Assassin;
                case 1:
                    Console.WriteLine("You are a Blitzen Blooper!");
                    return this.Type = CharacterType.BlitzenBlopper;
                case 2:
                    Console.WriteLine("You are a Professor!");
                    return this.Type = CharacterType.Professor;
                case 3:
                    Console.WriteLine("You are a Horse Mange!");
                    return this.Type = CharacterType.HorseMange;
                case 4:
                    Console.WriteLine("You are a Tax Man!");
                    return this.Type = CharacterType.TaxMan;
                case 5:
                    Console.WriteLine("You are a Human!");
                    return this.Type = CharacterType.Human;
                default:
                    Console.WriteLine("You are a Horse Mange because you did not pick a Character Type. So you are stuck being a Horse Mange! Good Luck!!");
                    return this.Type = CharacterType.HorseMange;
            }
        }
        public override string ToString()
        {
            return $"player Name: {this.PlayerName}\nGamer Name: {this.Clan}\nPlayer Type: {this.Type}";
        }
        public void PowerLevelCheck()
        {
            Console.WriteLine("{0}'s Health is at {1}.", this.PlayerName, this.CurrentPower);
        }
        public void BattleCry()
        {
            Console.WriteLine("FOR NARNIA!!!!!!!!!!!!!");
        }
        
    }
}
