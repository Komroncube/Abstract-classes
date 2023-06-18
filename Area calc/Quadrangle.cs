using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_calc
{
    public class Quadrangle : Shapes
    {
        public Quadrangle(float A, float B, float C, float D) 
        {
            if (A*B>0 && C*D>0 && A*B*C>0)
            {
                a= A; b = B; c= C; d= D;
            }
            else
            {
                Console.WriteLine("Length of sides of this shape must be positive");
            }
        }
        protected float a=0;
        protected float b=0; 
        protected float c=0;   
        protected float d=0;
        public override void area()
        {
            
        }
    }
}
