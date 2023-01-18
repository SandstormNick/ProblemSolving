﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ProblemSolving
    {
        //Not added to website yet
        public string RecursiveRemove(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            List<char> charList = new List<char>(charArray);
            int stringLength = inputString.Length;
            bool performedRemoval = true;

            while (performedRemoval)
            {
                for (int i = 0; i < charList.Count - 1; i++)
                {
                    if (charList[i] == charList[i + 1])
                    {
                        int startIndex = i;
                        int removeCounter = 2;
                        i = i + 1;
                        if (i < charList.Count - 1)
                        {
                            while (charList[i] == charList[i + 1])
                            {
                                removeCounter++;
                                i++;
                            }
                        }
                        charList.RemoveRange(startIndex, removeCounter);
                        i = startIndex;
                    }
                }
                if (stringLength != charList.Count)
                {
                    stringLength = charList.Count;
                }
                else
                {
                    performedRemoval = false;
                }
            }
            

            return new string(charList.ToArray());
        }

        //Not added to website yet
        public bool IsRotated(string rotateString, string compareString)
        {
            string originalString = rotateString;

            rotateString = rotateString.Substring(2, rotateString.Length - 2) + rotateString.Substring(0,2);
            if (rotateString == compareString)
                return true;
            else
                rotateString = originalString;

            rotateString = rotateString.Substring(rotateString.Length - 2, 2) + rotateString.Substring(0, rotateString.Length - 2);
            if (rotateString == compareString)
                return true;

            return false;
        }

        public int RomanToDecimal(string romanNumber)
        {
            //A switch case would be easier to read

            //Method caters for Roman Numerals below 5000
            char[] charsArray = romanNumber.ToCharArray();
            int total = 0;

            for (int i = 0; i < charsArray.Length; i++)
            {
                if (charsArray[i] == 'M')
                {
                    if (i != 0)
                    {
                        if (charsArray[i - 1] == 'C')
                            total += 900;
                        else
                            total += 1000;
                    }
                    else
                    {
                        total += 1000;
                    }
                }

                if (charsArray[i] == 'D')
                {
                    if (i != 0)
                    {
                        if (charsArray[i - 1] == 'C')
                            total += 400;
                        else
                            total += 500;
                    }
                    else
                    {
                        total += 500;
                    }
                }

                if (charsArray[i] == 'C')
                {
                    if (i != 0)
                    {
                        if (charsArray[i - 1] == 'X')
                            total += 90;
                        else
                        {
                            if (i < charsArray.Length - 1)
                            {
                                if (charsArray[i + 1] != 'D' && charsArray[i + 1] != 'M')
                                    total += 100;
                            }
                            else
                            {
                                total += 100;
                            }
                        }
                    }
                    else
                    {
                        if (i < charsArray.Length - 1)
                        {
                            if (charsArray[i + 1] != 'D' && charsArray[i + 1] != 'M')
                                total += 100;
                        }
                        else
                        {
                            total += 100;
                        }
                    }
                }

                if (charsArray[i] == 'L')
                {
                    if (i != 0)
                    {
                        if (charsArray[i - 1] == 'X')
                            total += 40;
                        else
                        {
                            total += 50;
                        }
                    }
                    else
                    {
                        if (i < charsArray.Length - 1)
                        {
                            if (charsArray[i + 1] != 'D' && charsArray[i + 1] != 'M')
                                total += 50;
                        }
                        else
                        {
                            total += 50;
                        }
                    }
                }

                if (charsArray[i] == 'X')
                {
                    if (i != 0)
                    {
                        if (charsArray[i - 1] == 'I')
                            total += 9;
                        else
                        {
                            if (i < charsArray.Length - 1)
                            {
                                if (charsArray[i + 1] != 'L' && charsArray[i + 1] != 'C')
                                    total += 10;
                            }
                            else
                            {
                                total += 10;
                            }
                        }
                    }
                    else
                    {
                        if (i < charsArray.Length - 1)
                        {
                            if (charsArray[i + 1] != 'L' && charsArray[i + 1] != 'C')
                                total += 10;
                        }
                        else
                        {
                            total += 10;
                        }   
                    }
                }

                if (charsArray[i] == 'V')
                {
                    if (i != 0)
                    {
                        if (charsArray[i - 1] == 'I')
                            total += 4;
                        else
                            total += 5;
                    }
                    else
                    {
                        total += 5;
                    }
                }

                if (charsArray[i] == 'I')
                {
                    if (i != 0)
                    {
                        if (charsArray[i - 1] == 'I')
                            total += 1;
                        else
                        {
                            if (i < charsArray.Length - 1)
                            {
                                if (charsArray[i + 1] != 'X' && charsArray[i + 1] != 'V')
                                    total += 1;
                            }
                            else
                            {
                                total += 1;
                            }
                        }
                    }
                    else
                    {
                        if (i < charsArray.Length - 1)
                        {
                            if (charsArray[i + 1] == 'I')
                                total += 1;
                        }
                        else
                        {
                            total += 1;
                        }
                            
                    }
                }
                
            }

            return total;
        }

        //Not added to website yet
        public bool IsAnagram(string stringA, string stringB)
        {
            stringA = stringA.ToLower();
            stringB = stringB.ToLower();

            char[] charArrayA = stringA.ToCharArray();
            char[] charArrayB = stringB.ToCharArray();

            Array.Sort(charArrayA);
            Array.Sort(charArrayB);

            stringA = new string(charArrayA);
            stringB = new string(charArrayB);

            if (stringA == stringB)
                return true;
            else
                return false;
        }

        //Not added to website yet
        public string RemoveDups(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            List<char> oringalChars = new List<char>(charArray);
            List<char> uniqueChars = new List<char>();

            for (int i = 0; i < oringalChars.Count; i++)
            {
                if (uniqueChars.Contains(oringalChars[i]))
                {
                    oringalChars.RemoveAt(i);
                    i -= 1;
                }
                else
                {
                    uniqueChars.Add(oringalChars[i]);
                }
            }

            inputString = new string(oringalChars.ToArray());

            return inputString;
        }

        //Not added to website yet
        public int CountMin(string stringInput)
        {
            char[] charArray = stringInput.ToCharArray();
            bool isPalindrome = true;
            int i = 0;

            while (isPalindrome && i < charArray.Length - 1)
            {
                if (charArray[i] != charArray[charArray.Length - (i + 1)])
                    isPalindrome = false;

                i++;
            }

            if (isPalindrome)
                return 0;

            //check for string of matching chars on either end of the string
            bool matchingChars = true;
            int matchingCharsCount = 1;
            int x = 0;
            while (matchingChars && x < charArray.Length - 1)
            {
                if ((charArray[x] != charArray[x + 1]) && (charArray[charArray.Length - (x + 1)] != charArray[charArray.Length - (x + 2)]))
                    matchingChars = false;
                else
                    matchingCharsCount++;

                x++;
            }

            return charArray.Length - matchingCharsCount;
        }

        //Not added to website yet
        public int Atoi(string stringInput)
        {
            char[] charArray = stringInput.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (i == 0)
                {
                    if (!"-0123456789".Contains(charArray[i]))
                        return -1;
                }
                if (i > 0)
                {
                    if (!"0123456789".Contains(charArray[i]))
                        return -1;
                }
            }

            return int.Parse(stringInput);
        }

        //Not added to website yet
        public int StrStr(string stringInput, string target)
        {
            if (stringInput.Contains(target))
            {
                return stringInput.IndexOf(target);
            }

            return -1;
        }

        public string LongestCommonPrefix(string[] stringArray)
        {
            return "";
        }
    }
}
