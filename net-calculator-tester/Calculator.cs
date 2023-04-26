using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        public float A { get; set; }
        public float B { get; set; }

        public Calculator(float a, float b)
        {
            this.A = a;
            this.B = b;
        }

        public float Add()
        {
            return this.A + this.B;
        }
        
        
        
        public float Substract()
        {
            return this.A - this.B;
        }
        
        
        
        public float Multiply()
        {
            return this.A * this.B;
        }
        
        
        
        public float Divide()
        {
            return this.A / this.B;
        }
        
        
        public float Power()
        {
            float pow = 1;

            if (this.B > 0)
            {
                for (int i = 0; i < this.B; i++)
                {
                    pow *= this.B;
                }
                
            }
            else if(this.B < 0)
            {
                this.B *= -1;

                for (int i = 0; i < this.B; i++)
                {

                    pow *= (float)1 / this.A;

                }
                
            }
            
            if (this.A == 0)
            {
                pow = 1;
            }

            return pow;
            
        }
    }
}
