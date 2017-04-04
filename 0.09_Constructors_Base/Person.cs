using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Base
{
    class Person
    {
        public Person()
        {

        }
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual void TestMethod()
        {
            Console.WriteLine("Demo method in Person Class");
        }

    }
}
