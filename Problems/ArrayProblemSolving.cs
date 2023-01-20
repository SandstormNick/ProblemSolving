using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ArrayProblemSolving
    {
        //Not added to website
        public int[] SubarraySum(int[] intArray, int expectedTotal)
        {
            int runningTotal = 0, firstElementPosition = 0, lastElementPosition = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                runningTotal += intArray[i];
                lastElementPosition = i;

                if (runningTotal == expectedTotal)
                    break;

                if (i == intArray.Length - 1 || runningTotal > expectedTotal)
                {
                    firstElementPosition++;
                    i = firstElementPosition - 1;
                    runningTotal = 0;
                }
            }

            int[] returnArray = { firstElementPosition, lastElementPosition };
            return returnArray;
        }
    }
}
