using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
using System.Runtime.Intrinsics.Arm;

namespace UnitTest
{
    //naming convention = ClassName_methodName
    [TestClass]
    public class StringUnitTest
    {
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

    [TestClass]
    public class ArrayUnitTest
    {
        [TestMethod]
        public void ArrayProblemSolving_SubarraySum()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray = { 1, 2, 3, 7, 5 };
            int expectedTotal = 12;
            int[] expectedArray = { 1, 3 };
            int[] actualArray = aps.SubarraySum(inputArray, expectedTotal);
            CollectionAssert.AreEqual(expectedArray, actualArray);


            int[] inputArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int expectedTotal2 = 15;
            int[] expectedArray2 = { 0, 4 };
            int[] actualArray2 = aps.SubarraySum(inputArray2, expectedTotal2);
            CollectionAssert.AreEqual(expectedArray2, actualArray2);
        }

        [TestMethod]
        public void ArrayProblemSolving_CountTriplet()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray = { 1, 5, 3, 2 };
            Assert.AreEqual(2, aps.CountTriplet(inputArray));

            int[] inputArray2 = { 2, 3, 4 };
            Assert.AreEqual(0, aps.CountTriplet(inputArray2));

            int[] inputArray3 = { 10, 12, 20, 8, 2, 4, 6, 1 };
            Assert.AreEqual(7, aps.CountTriplet(inputArray3)); //does not equal

            int[] inputArray4 = { 2, 48, 16, 50, 5 };
            Assert.AreEqual(1, aps.CountTriplet(inputArray4));

            int[] inputArray5 = { 9, 10, 8, 5, 6, 4, 7, 3, 1, 2 }; 
            Assert.AreEqual(20, aps.CountTriplet(inputArray5)); //does not equal
        }

        [TestMethod]
        public void ArrayProblemSolving_MaxSubarraySum()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray = { 1, 2, 3, -2, 5 };
            Assert.AreEqual(9, aps.MaxSubarraySum(inputArray));

            int[] inputArray2 = { -1, -2, -3, -4, -5 };
            Assert.AreEqual(-1, aps.MaxSubarraySum(inputArray2));

            int[] inputArray3 = { 6, 4, -1, 3, -15, 10, 5, -14, 13, -2 };
            Assert.AreEqual(15, aps.MaxSubarraySum(inputArray3));
        }

        [TestMethod]
        public void ArrayProblemSolving_MissingNumber()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray = { 6, 1, 2, 8, 3, 4, 7, 10, 5 };
            Assert.AreEqual(9, aps.MissingNumber(inputArray));

            int[] inputArray2 = { 1, 2, 3, 5 };
            Assert.AreEqual(4, aps.MissingNumber(inputArray2));
        }

        [TestMethod]
        public void ArrayProblemSolving_Merge()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray1 = { 1, 3, 5, 7 };
            int[] inputArray2 = { 0, 2, 6, 8, 9 };
            int[] expectedArray = { 0, 1, 2, 3, 5, 6, 7, 8, 9 };
            int[] actualArray = aps.Merge(inputArray1, inputArray2);
            CollectionAssert.AreEqual(expectedArray, actualArray);


            int[] inputArray3 = { 10, 12 };
            int[] inputArray4 = { 5, 18, 20 };
            int[] expectedArray2 = { 5, 10, 12, 18, 20 };
            int[] actualArray2 = aps.Merge(inputArray3, inputArray4);
            CollectionAssert.AreEqual(expectedArray2, actualArray2);
        }

        [TestMethod]
        public void ArrayProblemSolving_Rearrange()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray1 = { 1, 2, 3, 4, 5, 6 };
            int[] expectedArray1 = { 6, 1, 5, 2, 4, 3 };
            CollectionAssert.AreEqual(expectedArray1, aps.Rearrange(inputArray1));

            int[] inputArray2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };
            int[] expectedArray2 = { 110, 10, 100, 20, 90, 30, 80, 40, 70, 50, 60 };
            CollectionAssert.AreEqual(expectedArray2, aps.Rearrange(inputArray2));
        }

        [TestMethod]
        public void ArrayProblemSolving_Sort012()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray1 = { 1, 0, 2, 2, 1, 1 };
            int[] expectedArray1 = { 0, 1, 1, 1, 2, 2 };
            CollectionAssert.AreEqual(expectedArray1, aps.Sort012(inputArray1));

            int[] inputArray2 = { 1, 0, 2, 2, 1, 1, 2, 0, 0, 1 };
            int[] expectedArray2 = { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2 };
            CollectionAssert.AreEqual(expectedArray2, aps.Sort012(inputArray2));
        }

        [TestMethod]
        public void EquilibriumPoint()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray1 = { 1, 3, 5, 2, 2 };
            Assert.AreEqual(3, aps.EquilibriumPoint(inputArray1));

            int[] inputArray2 = { 1 };
            Assert.AreEqual(1, aps.EquilibriumPoint(inputArray2));

            int[] inputArray3 = { 1, 2, 2, 9, 2, 3 };
            Assert.AreEqual(4, aps.EquilibriumPoint(inputArray3));
        }

        [TestMethod]
        public void Leader()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] inputArray1 = { 16, 17, 4, 3, 5, 2 };
            int[] expectedArray1 = { 17, 5, 2 };
            CollectionAssert.AreEqual(expectedArray1, aps.Leader(inputArray1));

            int[] inputArray2 = { 12, 19, 10, 9, 5, 8, 1, 4 };
            int[] expectedArray2 = { 19, 10, 9, 8, 4 };
            CollectionAssert.AreEqual(expectedArray2, aps.Leader(inputArray2));
        }

        [TestMethod]
        public void MinimumPlatforms()
        {
            ArrayProblemSolving aps = new ArrayProblemSolving();
            int[] arrival = { 0900, 0940, 0950, 1100, 1500, 1800 };
            int[] depart = { 0910, 1200, 1120, 1130, 1900, 2000 };
            Assert.AreEqual(3, aps.MinimumPlatforms(arrival, depart, 6));


            int[] arrival2 = { 0900, 1100, 1235 };
            int[] depart2 = { 1000, 1200, 1240 };
            Assert.AreEqual(1, aps.MinimumPlatforms(arrival2, depart2, 3));

            int[] arrival3 = { 0900, 1000, 1030, 1100, 1200, 1210 };
            int[] depart3 = { 1000, 1020, 1650, 1130, 1230, 1245 };
            Assert.AreEqual(3, aps.MinimumPlatforms(arrival3, depart3, 6));
        }
    }
}