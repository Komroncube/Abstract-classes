using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_calc
{
    public class Rectangle : Quadrangle
    {
        public Rectangle(float a, float b) : base(a,b,a,b)
        { }
        public override void area()
        {
            Console.WriteLine($"S(rectangle) = {a * b:.02}");
        }
    }
}
