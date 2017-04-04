using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Challenge
{
    abstract class AbstractRegularPolygon
    {
        public int NumberofSides { get; set; }
        public int SideLength { get; set; }

        public AbstractRegularPolygon(int sides, int length)
        {
            this.NumberofSides = sides;
            this.SideLength = length;
        }
        public double GetPerimeter()
        {
            return NumberofSides * SideLength;
        }
        public abstract double GetArea();
    }
}
