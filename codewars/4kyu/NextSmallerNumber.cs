using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.codewars.com/kata/next-smaller-number-with-the-same-digits/train/csharp
namespace codewars
{
    public partial class Kata
    {
        public static long NextSmaller(long n)
        {
            var digits = n.ToString().ToCharArray();
            if (digits.Length <= 1)
                return -1;

            int nth;
            for (nth = digits.Length - 1; nth > 0; nth--)
            {
                if (digits[nth] < digits[nth - 1])
                    break;
            }
            if (nth == 0) return -1;

            char x = digits[nth - 1];
            int biggest = nth;
            for (int j = nth + 1; j < digits.Length; j++)
            {
                if (digits[j] < x && digits[j] > digits[biggest])
                {
                    biggest = j;
                }
            }

            var temp = digits[biggest];
            digits[biggest] = digits[nth - 1];
            digits[nth - 1] = temp;

            if (digits[0].Equals('0'))
                return -1;

            var result = digits
                .Take(nth)
                .Concat(digits.Skip(nth).OrderByDescending(c => c))
                .ToArray();

            return long.Parse(new string(result));
        }
    }
}
