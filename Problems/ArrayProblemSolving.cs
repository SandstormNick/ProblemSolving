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
                    pointer++;
                    i = pointer - 1;
                }
            }

            return triplets;
        }

        //Not added to website
        public int MaxSubarraySum(int[] inputArray)
        {
            int sum = inputArray[0];
            int pointer = 0;

            while (pointer < inputArray.Length)
            {
                int temp = 0;
                for (int i = pointer; i < inputArray.Length; i++)
                {
                    temp += inputArray[i];
                    if (temp > sum)
                    {
                        sum = temp;
                    }
                }
                pointer++;
            }

            return sum;
        }

        //Not added to website
        public int MissingNumber(int[] inputArray)
        {
            //Given an array of size N-1 such that it only contains distinct integers in the range of 1 to N. (Don't include 0)
            //Find the missing element.

            int missingNumber = -1;

            Array.Sort(inputArray);
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != i + 1)
                {
                    missingNumber = i + 1;
                    break;
                }
            }

            return missingNumber;
        }

        //Not added to website
        public int[] Merge(int[] array1, int[] array2)
        {
            List<int> biggerList = new List<int>();
            List<int> smallerList = new List<int>();

            if (array1.Length < array2.Length)
            {
                biggerList = array2.Cast<int>().ToList();
                smallerList = array1.Cast<int>().ToList();
            }

            int outer = 0;
            int pointer = 0;

            while (outer < biggerList.Count)
            {
                for (int inner = 0; inner < smallerList.Count; inner++)
                {
                    if (outer + 1 < biggerList.Count && biggerList[outer] < smallerList[inner] && smallerList[inner] < biggerList[outer + 1])
                    {
                        int temp = biggerList[outer + 1];
                        biggerList[outer + 1] = smallerList[inner];
                        smallerList[inner] = temp;

                        outer++;
                        inner = 0;
                    }
                    else
                    {
                        outer = pointer;
                    }
                }
                pointer++;
            }

            smallerList.Sort();

            var mergedList = biggerList.Concat(smallerList);

            return mergedList.ToArray();

        }

        public int[] Rearrange(int[] inputArray)
        {
            return inputArray;
        }
    }
}
