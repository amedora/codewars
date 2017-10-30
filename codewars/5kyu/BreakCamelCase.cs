using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace codewars
{
    public partial class Kata
    {
        public static string BreakCamelCase(string str)
        {
            return Regex.Replace(str, "[A-Z]", (m) => $" {m.Captures[0]}");
        }
    }

    [TestFixture]
    public class BreakCamelCaseTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("camelCasing").Returns("camel Casing");
                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string str) => Kata.BreakCamelCase(str);
    }
}
