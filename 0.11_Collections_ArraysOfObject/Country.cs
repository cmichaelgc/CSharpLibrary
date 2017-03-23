using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Collections_ArraysOfObject
{
    class Country
    {

        //Constructors
        public Country(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }
        //Properies
        public string Name { get; set; }
        public string Capital { get; set; }


        public void PrintCountryDetails()
        {
            Console.WriteLine("The Capital of {0} is {1}.", this.Name, this.Capital);
        }
    }
}
