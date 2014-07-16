namespace RomanNumbers
{
    using System.Collections.Generic;
    using System.Globalization;

    class RomanToNumeric
    {
        public static readonly Dictionary<string, int> ReferenceConvert = new Dictionary<string, int>();
        public static readonly Dictionary<string, int> TwoCharReferenceConvert = new Dictionary<string, int>();

        static RomanToNumeric()
        {
            ReferenceConvert.Add("I", 1);
            ReferenceConvert.Add("V", 5);
            ReferenceConvert.Add("X", 10);
            ReferenceConvert.Add("L", 50);
            ReferenceConvert.Add("C", 100);
            ReferenceConvert.Add("D", 500);
            ReferenceConvert.Add("M", 1000);

            TwoCharReferenceConvert.Add("IV", 4);
            TwoCharReferenceConvert.Add("IX", 9);
            TwoCharReferenceConvert.Add("XL", 40);
            TwoCharReferenceConvert.Add("XC", 90);
            TwoCharReferenceConvert.Add("CD", 400);
            TwoCharReferenceConvert.Add("CM", 900);
        }

        public static int Convert(string romanToConvert)
        {
            int result = 0;
            foreach (var twoCharKey in TwoCharReferenceConvert.Keys)
            {
                if (romanToConvert.Contains(twoCharKey))
                {
                    result += TwoCharReferenceConvert[twoCharKey];
                    romanToConvert = romanToConvert.Replace(twoCharKey, string.Empty);
                }
            }
            foreach (char theChar in romanToConvert)
            {
                result += ReferenceConvert[theChar.ToString(CultureInfo.InvariantCulture)];
            }
            //result += romanToConvert.Sum(theChar => ReferenceConvert[theChar.ToString(CultureInfo.InvariantCulture)]);
            return result;
        }
    }
}