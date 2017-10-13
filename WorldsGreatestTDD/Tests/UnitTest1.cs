using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void multiply_zeros()
        {
            Assert.AreEqual(0, new Fraction(0).Multiply(new Fraction(0)).Nominator);
        }

        [TestMethod]
        public void multiply_whole_numbers()
        {
            Assert.AreEqual(2, new Fraction(1).Multiply(new Fraction(2)).Nominator);
        }

        [TestMethod]
        public void multiply_factions()
        {
            Assert.AreEqual(1, new Fraction(1).Multiply(new Fraction(1,2)).Nominator);
            Assert.AreEqual(2, new Fraction(1).Multiply(new Fraction(1,2)).Denominator);
        }

        [TestMethod]
        public void multiply_factions_with_negative_nominator()
        {
            Assert.AreEqual(-6, new Fraction(-3,8).Multiply(new Fraction(2, 9)).Nominator);
            Assert.AreEqual(72, new Fraction(-3,8).Multiply(new Fraction(2, 9)).Denominator);
        }
    }

    public class Fraction
    {
        public int Nominator;
        public readonly int Denominator;

        public Fraction(int nominator, int denominator = 1)
        {
            Nominator = nominator;
            this.Denominator = denominator;
        }

        public Fraction Multiply(Fraction operand)
        {
            return new Fraction(Nominator*operand.Nominator, Denominator*operand.Denominator);
        }
    }

}
