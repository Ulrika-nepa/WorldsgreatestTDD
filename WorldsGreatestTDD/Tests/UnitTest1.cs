using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void multiply_zeros()
        {
            Assert.AreEqual(new Fraction(0).Nominator, new Fraction(0).Multiply(new Fraction(0)).Nominator);
        }

        [TestMethod]
        public void multiply_whole_numbers()
        {
            Assert.AreEqual(new Fraction(2).Nominator, new Fraction(1).Multiply(new Fraction(2)).Nominator);
        }

        [TestMethod]
        public void multiply_factions()
        {
            Assert.AreEqual(new Fraction(1,2).Nominator, new Fraction(1).Multiply(new Fraction(1,2)).Nominator);
        }

        [TestMethod]
        public void multiply_factions_with_negative_nominator()
        {
            Assert.AreEqual(new Fraction(-6, 72).Nominator, new Fraction(-3,8).Multiply(new Fraction(2, 9)).Nominator);
        }
    }

    public class Fraction
    {
        public int Nominator;
        private readonly int denominator;

        public Fraction(int nominator, int denominator = 1)
        {
            Nominator = nominator;
            this.denominator = denominator;
        }

        public Fraction Multiply(Fraction operand)
        {
            return new Fraction(Nominator*operand.Nominator, denominator*operand.denominator);
        }
    }

}
