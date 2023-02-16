using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_geometric_shapes
{
    internal class Sqr
    {
        public int Side { get; set; }
        public int Perimeter()
        {
            return Side * 4;
        }
        public int Area()
        {
            return Side * Side;
        }

        public Sqr() { }
  
        public Sqr(int side)
        {
            Side = side;
        }   
    }
}
