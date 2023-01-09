using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ProblemSolving
    {
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
    }
}
