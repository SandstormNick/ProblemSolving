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

        [TestMethod]
        public void ProblemSolving_IsRotated()
        {
            ProblemSolving ps = new ProblemSolving();
            string rotateString = "amazon", compareString = "azonam";
            Assert.IsTrue(ps.IsRotated(rotateString, compareString));

            rotateString = "amazon"; compareString = "onamaz";
            Assert.IsTrue(ps.IsRotated(rotateString, compareString));

            rotateString = "geeksforgeeks"; compareString = "geeksgeeksfor";
            Assert.IsFalse(ps.IsRotated(rotateString, compareString));
        }

        [TestMethod]
        public void ProblemSolving_RomanToDecimal()
        {
            ProblemSolving ps = new ProblemSolving();
            string romanNumeral = "MMMCMXCIX";
            int number = ps.RomanToDecimal(romanNumeral);
            Assert.AreEqual(3999, number);

            romanNumeral = "CCCXLVIII";
            number = ps.RomanToDecimal(romanNumeral);
            Assert.AreEqual(348, number);

            romanNumeral = "LXXVII";
            number = ps.RomanToDecimal(romanNumeral);
            Assert.AreEqual(77, number);

            romanNumeral = "I";
            number = ps.RomanToDecimal(romanNumeral);
            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void ProblemSolving_IsAnagram()
        {
            ProblemSolving ps = new ProblemSolving();
            string stringA = "geeksforgeeks";
            string stringB = "forgeeksgeeks";
            Assert.IsTrue(ps.IsAnagram(stringA, stringB));

            stringA = "allergic";
            stringB = "allergy";
            Assert.IsFalse(ps.IsAnagram(stringA, stringB));
        }
    }
}