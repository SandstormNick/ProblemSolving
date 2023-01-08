using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace UnitTest
{
    [TestClass]
    public class ProblemsUnitTest
    {
        //naming convention = ClassName_methodName

        [TestMethod]
        public void LongestPalindrome_longestPalin()
        {
            LongestPalindrome lp = new LongestPalindrome();

            string longestPalin = "aaaabbaa";
            longestPalin = lp.longestPalin(longestPalin);
            Assert.AreEqual("aabbaa", longestPalin);

            longestPalin = "abcba";
            longestPalin = lp.longestPalin(longestPalin);
            Assert.AreEqual("abcba", longestPalin);

            longestPalin = "xfjtmofabbayzakrpxyzyxootb";
            longestPalin = lp.longestPalin(longestPalin);
            Assert.AreEqual("xyzyx", longestPalin);
        }
    }
}