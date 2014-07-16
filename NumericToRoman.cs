namespace RomanNumbers
{
    using System.Collections.Generic;
    using System.Linq;

    public class NumericToRoman
    {
        private static readonly Dictionary<int, string> ReferenceConvert = new Dictionary<int, string>();

        static NumericToRoman()
        {
            ReferenceConvert.Add(1, "I");
            ReferenceConvert.Add(4, "IV");
            ReferenceConvert.Add(5, "V");
            ReferenceConvert.Add(9, "IX");
            ReferenceConvert.Add(10, "X");
            ReferenceConvert.Add(40, "XL");
            ReferenceConvert.Add(50, "L");
            ReferenceConvert.Add(90, "XC");
            ReferenceConvert.Add(100, "C");
            ReferenceConvert.Add(400, "CD");
            ReferenceConvert.Add(500, "D");
            ReferenceConvert.Add(900, "CM");
            ReferenceConvert.Add(1000, "M");
        }

        public static string Convert(int numberToConvert)
        {
            var result = string.Empty;
            foreach (var refNumber in ReferenceConvert.Keys.OrderByDescending(item => item))
            {
                while (numberToConvert >= refNumber)
                {
                    result += ReferenceConvert[refNumber];
                    numberToConvert -= refNumber;
                }
            }
            return result;
        }
    }
}