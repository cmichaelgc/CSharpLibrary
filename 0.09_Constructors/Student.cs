using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }

        public Student()
        {

        }

        public Student(string Name)
        {
            this.Name = Name;
        }
        public Student(string Name, string LastName, int Age, string Level)
        {
            this.LastName = LastName;
            this.Name = Name;
            this.Age = Age;
            this.Level = Level;
        }
    }
}
