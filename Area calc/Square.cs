using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_calc
{
    public class Square : Quadrangle
    {
        public Square(float A) : base(A,A,A,A)
        {
            
        }
        public override void area()
        {
            Console.WriteLine($"S(square) = {a * b:0.00}");
        }
    }
}
