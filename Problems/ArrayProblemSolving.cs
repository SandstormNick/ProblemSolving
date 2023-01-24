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

        //Not added to website
        public int CountTriplet(int[] inputArray)
        {
            //inputArray = distinct integers
            Array.Sort(inputArray);
            Array.Reverse(inputArray);

            int triplets = 0;
            int currentInt = 0; //what we're trying to equal
            int pointer = 0; 
            //4 3 2
            //0 1 2
            //length = 4

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i + 1 < inputArray.Length && pointer != (i + 1) && inputArray[pointer] + inputArray[i+1] == inputArray[currentInt])
                {
                    triplets++;
                }

                if (i == inputArray.Length - 1 && i == pointer)
                {
                    currentInt++;
                    i = currentInt;
                    pointer = currentInt;
                }

                if (i == inputArray.Length - 1 && i != pointer)
                {
                    i = currentInt;
                    pointer++;
                }
            }

            return triplets;
        }
    }
}
