using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_calc
{
    public class Trapezium : Quadrangle
    {
        public Trapezium(float a, float b, float c, float d): base(a, b, c, d) { }
        public override void area()
        {

            double s = (a + b) / 2 * Math.Sqrt(Math.Pow(c, 2) - Math.Pow(((Math.Pow(a - b, 2) + Math.Pow(c, 2) - Math.Pow(d, 2)) / (2 * (a - b))), 2));
            Console.WriteLine($"S(trapezium) = {s:.02}");

        }
    }
}
