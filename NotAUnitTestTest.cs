﻿namespace RomanNumbers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NotAUnitTestTest
    {
        [TestMethod]
        public void ConvertionShouldBeReversed_NotUnit()
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int numberToConvert = 0; numberToConvert < 4000; numberToConvert++)
                {
                    var roman = NumericToRoman.Convert(numberToConvert);
                    var result = RomanToNumeric.Convert(roman);
                    Assert.AreEqual(numberToConvert, result);
                }
            }
        }
    }
}
