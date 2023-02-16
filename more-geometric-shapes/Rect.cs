using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_geometric_shapes
{
    internal class Rect
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public int Perimeter() {
            return 2 * (Side1 + Side2);
        }
        public int Area() {     
            return Side1 * Side2;
        }
        public Rect() { }
        public Rect(int side1, int side2)
        {
            Side1 = side1; 
            Side2 = side2;
            Perimeter();
            Area();
        }
    }
}
