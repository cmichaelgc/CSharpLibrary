using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_methods_challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Netflix show1 = new Netflix();
            show1.Name = "Daredevil";
            show1.Genre = "Action";
            show1.Rating = 3;
            show1.TotalMinutes = 55;
            show1.MinutesViewed = 15;

            Netflix show2 = new Netflix();
            show2.Name = "Orange is the New Black";
            show2.Genre = "Comedy, and Drama";
            show2.Rating = 2;
            show2.TotalMinutes = 25;
            show2.MinutesViewed = 30;

            Netflix show3 = new Netflix();
            show3.Name = "Narcos";
            show3.Genre = "Drama";
            show3.Rating = 3;
            show3.TotalMinutes = 55;
            show3.MinutesViewed = 49;


            show1.ShowRuntime();
            show1.GetSuggestion();
            show1.ShowWhoViewd("Lilly", "4pm");
            show1.ShowMinutesLeft(9);
            show2.ShowRuntime();
            show2.GetSuggestion();
            show2.ShowWhoViewd("Whitney", "10pm");
            show2.ShowMinutesLeft(15);
            show3.ShowRuntime();
            show3.GetSuggestion();
            show3.ShowWhoViewd("Charles", "1am");
            show3.ShowMinutesLeft(9);


            Console.ReadLine();
        }
    }
}
