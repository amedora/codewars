using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace codewars
{
    // https://www.codewars.com/kata/your-order-please/csharp
    public partial class Kata
    {
        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
                return "";

            return string.Join(" ", words
                .Split()
                .OrderBy(s => Regex.Replace(s, "[^0-9]", "")));
        }
    }
}
