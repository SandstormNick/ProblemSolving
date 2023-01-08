using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public  class LongestPalindrome
    {
        public string longestPalin(string inputString)
        {
            string longestPalindrome = inputString.Substring(0, 1);
            char[] chars = inputString.ToCharArray();

            bool stillPalin;
            string tempPalindrome;
            int leftChar, rightChar;

            for (int i = 0; i < chars.Length - 1; i++)
            {
                //check for groupings of 2
                if (chars[i] == chars[i + 1] && i < chars.Length)
                {
                    stillPalin = true;

                    tempPalindrome = chars[i].ToString() + chars[i + 1].ToString();
                    if (longestPalindrome.Length < tempPalindrome.Length)
                    {
                        longestPalindrome = tempPalindrome;
                    }

                    leftChar = i -1;
                    rightChar = i + 2;

                    while (stillPalin && leftChar > -1 && rightChar < chars.Length)
                    {
                        if (chars[leftChar] == chars[rightChar])
                        {
                            tempPalindrome = chars[leftChar].ToString() + tempPalindrome + chars[rightChar].ToString();
                            //Only assign value to longestPalindrome if the current palindrome string is longer
                            if (longestPalindrome.Length < tempPalindrome.Length)
                            {
                                longestPalindrome = tempPalindrome;
                            }
                            leftChar--;
                            rightChar++;
                        }
                        else
                        {
                            stillPalin = false;
                        }
                    }
                }

                //check for groupings of 3
                if (i < chars.Length - 2)
                {
                    if (chars[i] == chars[i + 2])
                    {
                        stillPalin = true;

                        tempPalindrome = chars[i].ToString() + chars[i + 1].ToString() + chars[i + 2].ToString();
                        if (longestPalindrome.Length < tempPalindrome.Length)
                        {
                            longestPalindrome = tempPalindrome;
                        }

                        leftChar = i - 1;
                        rightChar = i + 3;

                        while (stillPalin && leftChar > -1 && rightChar < chars.Length)
                        {
                            if (chars[leftChar] == chars[rightChar])
                            {
                                tempPalindrome = chars[leftChar].ToString() + tempPalindrome + chars[rightChar].ToString();
                                //Only assign value to longestPalindrome if the current palindrome string is longer
                                if (longestPalindrome.Length < tempPalindrome.Length)
                                {
                                    longestPalindrome = tempPalindrome;
                                }
                                leftChar--;
                                rightChar++;
                            }
                            else
                            {
                                stillPalin = false;
                            }
                        }
                    }
                }
            }

            return longestPalindrome;
        }
    }
}
