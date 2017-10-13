using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void multiply_whole_numbers()
        {
            var a = new Fraction(0);
            var b = new Fraction(0);
            var c = new Fraction(0);

            var result = a.Multiply(b);
            
            Assert.AreEqual(c.Value, result.Value);
        }
    }

    public class Fraction
    {
        public int Value;

        public Fraction(int value)
        {
            Value = value;
        }

        public Fraction Multiply(Fraction operand)
        {
            return new Fraction(Value*operand.Value);
        }
    }

}
