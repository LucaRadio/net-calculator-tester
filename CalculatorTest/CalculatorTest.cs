using net_calculator_tester;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        public Calculator calculator;
        [SetUp]
        public void Setup()
        {
           calculator = new Calculator(1,1);
        }

        [Test]
        public void AddTest()
        {
            
            Assert.That(calculator.Add(), Is.EqualTo(2));
        }
        
        
        [Test]
        public void SubstractTest()
        {
            Assert.That(calculator.Substract(), Is.EqualTo(0));
        }
        
        
        
        [Test]
        public void MultiplayTest()
        {
            Assert.That(calculator.Multiply(), Is.EqualTo(1));
        }
        
        
        [Test]
        public void DivideTest()
        {
            Assert.That(calculator.Divide(), Is.EqualTo(1));
        }
        
        
        [Test]
        public void PowerTest()
        {
            Assert.That(calculator.Power(), Is.EqualTo(1));
        }
    }
}