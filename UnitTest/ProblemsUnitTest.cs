using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace UnitTest
{
    [TestClass]
    public class ProblemsUnitTest
    {
        [TestMethod]
        public void TestMethod1longestPalin()
        {
            string longestPalin = "aaaabbaa";
            LongestPalindrome lp = new LongestPalindrome();
            longestPalin = lp.longestPalin(longestPalin);

        }
    }
}