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
            //aaaabbaa
            string longestPalindrome = inputString.Substring(0, 1);
            char[] chars = inputString.ToCharArray();

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1] && chars[i] != chars.Length - 1)
                {
                    bool stillPalin = true;
                    //longestPalin = inputString.Substring() --will need an if check to see if its necessary to assign to longestPalin
                    int leftChar = i -1;
                    int rightChar = i + 2;

                    while (stillPalin && leftChar > -1 && rightChar < chars.Length)
                    {
                        
                        stillPalin = false;
                    }
                }

                if (chars[i] == chars[i+ 2] && chars[i] != chars.Length - 2)
                {
                    bool stillPalin = true;
                }
                //check for grouping of 2

                //check for grouping of 3

                // =if it finds 2/3 then start another loop and look for matching chars on either side

                //the array limits need to be taken into account as well
            }

            return inputString;
        }
    }
}
