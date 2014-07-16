using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class NumericToRomanTest
    {
        [TestMethod]
        public void OneShouldBeI()
        {
            var result = NumericToRoman.Convert(1);
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void ThreeShouldBeIII()
        {
            var result = NumericToRoman.Convert(3);
            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void FourShouldBeIV()
        {
            var result = NumericToRoman.Convert(4);
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void SixShouldBeVI()
        {
            var result = NumericToRoman.Convert(6);
            Assert.AreEqual("VI", result);
        }

        [TestMethod]
        public void NineShouldBeIX()
        {
            var result = NumericToRoman.Convert(9);
            Assert.AreEqual("IX", result);
        }

        [TestMethod]
        public void ElevenShouldBeXI()
        {
            var result = NumericToRoman.Convert(11);
            Assert.AreEqual("XI", result);
        }

        [TestMethod]
        public void FourteenShouldBeXIV()
        {
            var result = NumericToRoman.Convert(14);
            Assert.AreEqual("XIV", result);
        }

        [TestMethod]
        public void TwentyShouldBeXX()
        {
            var result = NumericToRoman.Convert(20);
            Assert.AreEqual("XX", result);
        }

        [TestMethod]
        public void TirtyNineShouldBeXXXIX()
        {
            var result = NumericToRoman.Convert(39);
            Assert.AreEqual("XXXIX", result);
        }

        [TestMethod]
        public void FourHundredFourtyFourShouldBeCDXLIV()
        {
            var result = NumericToRoman.Convert(444);
            Assert.AreEqual("CDXLIV", result);
        }

        [TestMethod]
        public void NineHundredShouldBeCM()
        {
            var result = NumericToRoman.Convert(900);
            Assert.AreEqual("CM", result);
        }

        [TestMethod]
        public void NearTwoThousandShouldBeMCMXCIX()
        {
            var result = NumericToRoman.Convert(1999);
            Assert.AreEqual("MCMXCIX", result);
        }
        
    }
}
