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
            StringProblemSolving sps = new StringProblemSolving();

            string longestPalin = "aaaabbaa";
            longestPalin = sps.longestPalin(longestPalin);
            Assert.AreEqual("aabbaa", longestPalin);

            longestPalin = "abcba";
            longestPalin = sps.longestPalin(longestPalin);
            Assert.AreEqual("abcba", longestPalin);

            longestPalin = "xfjtmofabbayzakrpxyzyxootb";
            longestPalin = sps.longestPalin(longestPalin);
            Assert.AreEqual("xyzyx", longestPalin);
        }

        [TestMethod]
        public void DistinctCharacters_LongestSubstrDitinctChars()
        {
            StringProblemSolving sps = new StringProblemSolving();

            string testString = "geeksforgeeks";
            testString = sps.LongestSubstrDitinctChars(testString);
            Assert.AreEqual("efgkors", testString);

            testString = "aaa";
            testString = sps.LongestSubstrDitinctChars(testString);
            Assert.AreEqual("a", testString);
        }

        [TestMethod]
        public void ProblemSolving_RecursiveRemove()
        {
            StringProblemSolving ps = new StringProblemSolving();
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
            StringProblemSolving ps = new StringProblemSolving();
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
            StringProblemSolving ps = new StringProblemSolving();
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
            StringProblemSolving ps = new StringProblemSolving();
            string stringA = "geeksforgeeks";
            string stringB = "forgeeksgeeks";
            Assert.IsTrue(ps.IsAnagram(stringA, stringB));

            stringA = "allergic";
            stringB = "allergy";
            Assert.IsFalse(ps.IsAnagram(stringA, stringB));
        }

        [TestMethod]
        public void ProblemSolving_RemoveDups()
        {
            StringProblemSolving ps = new StringProblemSolving();
            string stringInput = "zvvo";
            stringInput = ps.RemoveDups(stringInput);
            Assert.AreEqual("zvo", stringInput);

            stringInput = "ffofofxxxxxfofofyofy";
            stringInput = ps.RemoveDups(stringInput);
            Assert.AreEqual("foxy", stringInput);
        }

        [TestMethod]
        public void ProblemSolving_CountMin()
        {
            StringProblemSolving ps = new StringProblemSolving();
            string stringInput = "abcd";
            int number = ps.CountMin(stringInput);
            Assert.AreEqual(3, number);

            stringInput = "abcba";
            number = ps.CountMin(stringInput);
            Assert.AreEqual(0, number);

            stringInput = "aa";
            number = ps.CountMin(stringInput);
            Assert.AreEqual(0, number);

            stringInput = "aaabcc";
            number = ps.CountMin(stringInput);
            Assert.AreEqual(3, number);

            stringInput = "xyfghtm";
            number = ps.CountMin(stringInput);
            Assert.AreEqual(6, number);
        }

        [TestMethod]
        public void ProblemSolving_Atoi()
        {
            StringProblemSolving ps = new StringProblemSolving();
            string stringInput = "123";
            Assert.AreEqual(123, ps.Atoi(stringInput));

            stringInput = "21a";
            Assert.AreEqual(-1, ps.Atoi(stringInput));

            stringInput = "-123";
            Assert.AreEqual(-123, ps.Atoi(stringInput));
        }

        [TestMethod]
        public void ProblemSolving_StrStr()
        {
            StringProblemSolving ps = new StringProblemSolving();
            string stringInput = "GeeksForGeeks";
            Assert.AreEqual(5, ps.StrStr(stringInput, "For"));

            stringInput = "GeeksForGeeks";
            Assert.AreEqual(-1, ps.StrStr(stringInput, "Fr"));
        }

        [TestMethod]
        public void ProblemSolving_LongestCommonPrefix()
        {
            StringProblemSolving ps = new StringProblemSolving();
            string[] stringArray = { "geeksforgeeks", "geeks", "geek", "geezer" };
            Assert.AreEqual("gee", ps.LongestCommonPrefix(stringArray));

            string[] stringArray2 = { "hello", "world" };
            Assert.AreEqual("-1", ps.LongestCommonPrefix(stringArray2));
        }
    }
}