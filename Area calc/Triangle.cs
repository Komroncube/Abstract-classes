using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_calc
{
    public class Triangle : Shapes
    {
        public Triangle(double A, double B, double C)
        {
            if (A < B + C && B < A + C && C < A + B)
            {
                a = A; b = B; c = C;
            }
        }
        public override void area()
        {    
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"S(triangle) = {s:.02}");
        }
        private double a = 0;
        private double b = 0;
        private double c = 0;
    }
}