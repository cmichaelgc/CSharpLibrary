using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_methods_challenge
{
    class Netflix
    {   //Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public int TotalMinutes { get; set; }
        public int MinutesViewed { get; set; }




        //Methods
        public void GetSuggestion()
        {
            Console.WriteLine("Show Name: {0}, Show Genre: {1}, Show Rating: {2}", Name, Genre, Rating);
            //Conditionals for getting results
            if (this.Rating <= 2)
            {
                Console.WriteLine("Find a new Show");
            }
            else
            {
                Console.WriteLine("Keep Watching!!!!");
            }
        }
        public int ShowRuntime()
        {
            Console.WriteLine(this.TotalMinutes + " Min");
            return this.TotalMinutes;
        }
        /// <summary>
        /// Methods that have parameters
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// 

        public string ShowWhoViewd(string username, string time)
        {

            string details = username + " watched this at " + time;
            Console.WriteLine(details);
            return details;

        }
        public int ShowMinutesLeft(int MinutesViewed)
        {
            int numMinutesLeft = this.TotalMinutes - MinutesViewed;
            Console.WriteLine("There is " + numMinutesLeft + " minutes left in " + this.Name);
            return numMinutesLeft;
        }
    }
}
