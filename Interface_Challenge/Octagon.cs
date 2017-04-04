using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Challenge
{
    class Octagon : IRegularPolygon
    {
        public int NumberofSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int length)
        {
            this.NumberofSides = 8;
            this.SideLength = length;
        }

        public double GetArea()
        {
            return SideLength * SideLength (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return NumberofSides * SideLength;
        }
    }
}
