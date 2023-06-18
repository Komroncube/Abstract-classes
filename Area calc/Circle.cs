using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_calc
{
    public class Circle : Shapes
    {
        public Circle(float R)
        {
            if (R>0)
            {
                r = R;
            }
        }
        private const double PI= Math.PI;
        private float r=0;
        public override void area()
        {
            double s = Math.Pow(r, 2) * PI;
            Console.WriteLine($"S(circle) = {s:0.00}");
        }

    }
}
