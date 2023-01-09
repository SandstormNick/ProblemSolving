using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class DistinctCharacters
    {
        public string LongestSubstrDitinctChars(string stringInput)
        {
            char[] charArray = stringInput.ToCharArray();
            Array.Sort(charArray);
            char currentChar = charArray[0];
            string distinctChars = currentChar.ToString();

            for (int i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] != currentChar)
                {
                    currentChar = charArray[i];
                    distinctChars+= currentChar.ToString();
                }
            }

            return distinctChars;
        }
    }
}
