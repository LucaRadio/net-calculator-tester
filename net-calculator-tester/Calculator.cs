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


        public float Add(float a, float b)
        {
            return a + b;
        }
        
        
        
        public float Substract(float a, float b)
        {
            return a - b;
        }
        
        
        
        public float Multiply(float a, float b)
        {
            return a * b;
        }
        
        
        
        public float Divide(float a, float b)
        {
            if (b == 0)
            {
                return float.NaN;
            }
            return a / b;
        }
        
        
        public float Power(float a, float b)
        {
            float pow = 1;
            if (b == 0)
            {
                pow = 1;
                return pow;
            }

            if (b > 0)
            {
                for (int i = 0; i < b; i++)
                {
                    pow *= a;

                }
                
            }
            else if(b < 0)
            {
                b *= -1;

                for (int i = 0; i < b; i++)
                {

                    pow *= (float)1 / a;

                }
                
            }
            

            return pow;
            
        }
    }
}
