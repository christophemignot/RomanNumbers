using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanToNumericTest
    {
        [TestMethod]
        public void IShouldBeOne()
        {
            var result = RomanToNumeric.Convert("I");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IIIShouldBeThree()
        {
            var result = RomanToNumeric.Convert("III");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void IVShouldBeFour()
        {
            var result = RomanToNumeric.Convert("IV");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void VIShouldBeSix()
        {
            var result = RomanToNumeric.Convert("VI");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void IXShouldBeNine()
        {
            var result = RomanToNumeric.Convert("IX");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void XIShouldBeEleven()
        {
            var result = RomanToNumeric.Convert("XI");
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void XIVShouldBeFourteen()
        {
            var result = RomanToNumeric.Convert("XIV");
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void XXShouldBeTwenty()
        {
            var result = RomanToNumeric.Convert("XX");
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void XXXIXNineShouldBeTirty()
        {
            var result = RomanToNumeric.Convert("XXXIX");
            Assert.AreEqual(39, result);
        }

        [TestMethod]
        public void CDXLIVShouldBeFourHundredFourtyFour()
        {
            var result = RomanToNumeric.Convert("CDXLIV");
            Assert.AreEqual(444, result);
        }

        [TestMethod]
        public void CMShouldBeNineHundred()
        {
            var result = RomanToNumeric.Convert("CM");
            Assert.AreEqual(900, result);
        }

        [TestMethod]
        public void MCMXCIXShouldBeNearTwoThousand()
        {
            var result = RomanToNumeric.Convert("MCMXCIX");
            Assert.AreEqual(1999, result);
        }
    }
}
