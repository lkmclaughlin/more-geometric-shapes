using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_geometric_shapes
{
    internal class Triangle
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int Height { get; set; }

        public int Perimeter()
        {
            return SideA + SideB + SideC;    
        }
        public int Area()
        {
            return (Height * SideB) / 2;
        }
        
        public Triangle() { }
        public Triangle(int sideA, int sideB, int sideC, int height)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = height;
        }
    }
}
