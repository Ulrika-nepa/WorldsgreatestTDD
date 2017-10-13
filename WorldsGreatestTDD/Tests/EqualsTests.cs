using System;
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


    }
}
