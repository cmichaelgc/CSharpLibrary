using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Dictionaries_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //flip key and value to run correctly
            Dictionary<string, string> movies = new Dictionary<string, string>();
            movies.Add("2000", "Gladiator",);
            movies.Add("2001", "A Beautiful Mind",);
            movies.Add("2002", "Chicago",);
            movies.Add("2003", "The Lord of the Rings: The Return of the King");
            movies.Add("2004", "Million Dollar Baby");
            movies.Add("2005", "Crash",);


            foreach(KeyValuePair<string, string> pair in movies)
            {
                Console.WriteLine("{0} won best picture in {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("=============================================");
            Dictionary<string, string[]> bestPictureNoms = new Dictionary<string, string[]>();

            bestPictureNoms.Add("2000", new string[] { "Gladiator", "Chocolat", "CTHD" });
            bestPictureNoms.Add("2001", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom" });
            bestPictureNoms.Add("2002", new string[] { "Chicago", "Gangs of New York", "Harry Potter CS" });

            foreach(KeyValuePair<string, string[]> bestpictureNom in bestPictureNoms)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", bestpictureNom.Key, bestpictureNom.Value[0], bestpictureNom.Value[1], bestpictureNom.Value[2]);
            }
            Console.WriteLine("========================================");

            Console.WriteLine(movies["2002"]);
            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();

            if (movies.ContainsKey(input1))
            {
                string valueForKey = movies[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey);
            }
            Console.WriteLine("Please type the year to show the movies that were up for an award that year:");
            string input2 = Console.ReadLine();
            if (bestPictureNoms.ContainsKey(input2))
            {
                string[] valueForKey = bestPictureNoms[input2];
                string nomineeString = string.Join(", ", valueForKey);
                Console.WriteLine("The best picture nominees in " + input2 + " were " + nomineeString);
            }




            Console.ReadLine();
        }
    }
}
