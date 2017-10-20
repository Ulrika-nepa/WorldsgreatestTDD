using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldsGreatestTDD;

namespace Tests
{
    [TestClass]
    public class EqualsTests
    {
        [TestMethod]
        public void nominators_are_equal()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(1));
        }

        [TestMethod]
        public void nominators_are_not_equal()
        {
            Assert.AreNotEqual(new Fraction(1), new Fraction(2));
        }

        [TestMethod]
        public void fraction_is_null()
        {
            Assert.AreNotEqual(new Fraction(1), null);
        }

    }
}
