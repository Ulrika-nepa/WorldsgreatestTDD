using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new Fraction(0);
            var b = new Fraction(0);
            var c = new Fraction(0);

            var calculator = new Calculator();
            var result = calculator.Add(a, b);
            
            Assert.AreEqual(c.v, result.v);
        }
    }

    internal class Fraction
    {
        public int v;

        public Fraction(int v)
        {
            this.v = v;
        }
        
    }

    internal class Calculator
    {
        public Calculator()
        {
        }

        public Fraction Add(Fraction fraction, Fraction fraction1)
        {
            return new Fraction(0);
        }


    }
}
