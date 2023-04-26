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
    }
}
