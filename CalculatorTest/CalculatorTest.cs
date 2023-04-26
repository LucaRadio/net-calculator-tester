using net_calculator_tester;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        public Calculator calculator;
        [SetUp]
        public void Setup()
        {
           calculator = new Calculator();
        }

        [TestCase(1,1,2)]
        public void AddTest(float a,float b,float result)
        {
            
            Assert.That(calculator.Add(a,b), Is.EqualTo(result));
        }



        [TestCase(1, 1,0)]
        public void SubstractTest(float a, float b,float result)
        {
            Assert.That(calculator.Substract(a,b), Is.EqualTo(result));
        }




        [TestCase(1, 1,1)]
        public void MultiplayTest(float a, float b,float result)
        {
            Assert.That(calculator.Multiply(a, b), Is.EqualTo(result));
        }



        [TestCase(1, 1,1)]
        [TestCase(1, 0,float.NaN)]
        public void DivideTest(float a, float b,float result)
        {
            if (b == 0)
            {
                Assert.That(calculator.Divide(a, b), Is.EqualTo(float.NaN));
            }
            else
            {
                Assert.That(calculator.Divide(a, b), Is.EqualTo(result));

            }
        }
        
        
        
        [TestCase(1,1,1)]
        [TestCase(0,3,0)]
        [TestCase(645,0,1)]
        public void PowerTest(float a, float b,float result)
        {
            Assert.That(calculator.Power(a, b), Is.EqualTo(result));
        }
    }
}