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

        [TestMethod]
        public void DistinctCharacters_LongestSubstrDitinctChars()
        {
            DistinctCharacters dc = new DistinctCharacters();

            string testString = "geeksforgeeks";
            testString = dc.LongestSubstrDitinctChars(testString);
            Assert.AreEqual("efgkors", testString);

            testString = "aaa";
            testString = dc.LongestSubstrDitinctChars(testString);
            Assert.AreEqual("a", testString);
        }

        [TestMethod]
        public void ProblemSolving_RecursiveRemove()
        {
            ProblemSolving ps = new ProblemSolving();
            string testString = "geeksforgeek";
            testString = ps.RecursiveRemove(testString);
            Assert.AreEqual("gksforgk", testString);

            testString = "abccbccba";
            testString = ps.RecursiveRemove(testString);
            Assert.AreEqual("", testString);
        }
    }
}