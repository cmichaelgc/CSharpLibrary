using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Challenge
{
    class Polygon
    {
        public int NumberofSides { get; set; }
        public int SideLength { get; set; }

        public Polygon(int sides, int length)
        {
            this.NumberofSides = sides;
            this.SideLength = length;
        }
        public double GetPerimeter()
        {
            return NumberofSides * SideLength;
        }
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
