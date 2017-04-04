using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Base
{
    class Minor : Person
    {
        public Minor(string firstName, string lastName, int age, bool isInSchool) : base(firstName, lastName, age)
        {
            this.IsInSchool = IsInSchool;
        }

        public bool IsInSchool { get; set; }

        public override void TestMethod()
        {
            Console.WriteLine("Test method in Minor Class");
        }
        public void DemoMethod()
        {
            Console.WriteLine("Demo Method in Minor Class");
        }
    }
}
