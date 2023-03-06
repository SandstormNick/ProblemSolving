using System;
using System.Collections.Generic;
using System.Drawing;
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
            int tempHigh;

            for (int outer = 0; outer < inputArray.Length; outer+=2)
            {
                tempHigh = inputArray[inputArray.Length - 1];

                for (int inner = inputArray.Length - 1; inner > outer; inner--)
                {
                    inputArray[inner] = inputArray[inner - 1];
                }
                inputArray[outer] = tempHigh;
            }

            return inputArray;
        }

        public int[] Sort012(int[] inputArray)
        {
            //Given an array of size N containing only 0s, 1s, and 2s; sort the array in ascending order.

            //Array.Sort(inputArray); --> Cheat way

            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        (inputArray[i], inputArray[i + 1]) = (inputArray[i + 1], inputArray[i]);
                        sorted = false;
                    }
                }
            }

            return inputArray;
        }

        public int EquilibriumPoint(int[] inputArray)
        {
            //Given an array A of n positive numbers. The task is to find the first Equilibrium Point in an array. 
            //Equilibrium Point in an array is a position such that the sum of elements before it is equal to the sum of elements after it.

            //The task is to complete the function equilibriumPoint() which takes the array and n as input parameters and returns the point of equilibrium.
            //Return -1 if no such point exists.

            //convert array to list
            List<int> inputList = inputArray.OfType<int>().ToList();

            int beforeEquilibrium = 0;
            int afterEquilibrium = 0;
            int equilibriumPoint = -1;

            if (inputList.Count == 1)
                return 1;

            for (int i = 1; i < inputList.Count - 1; i++)
            {
                beforeEquilibrium = inputList.GetRange(0, i).Sum();
                afterEquilibrium = inputList.GetRange(i + 1, inputList.Count - (i + 1)).Sum();

                if (beforeEquilibrium == afterEquilibrium)
                {
                    equilibriumPoint = i + 1;
                    break;
                }
            }

            return equilibriumPoint;
        }

        public int[] Leader(int[] inputArray)
        {
            //Given an array A of positive integers. Your task is to find the leaders in the array.
            //An element of array is leader if it is greater than or equal to all the elements to its right side.
            //The rightmost element is always a leader. 

            //A[] = { 16, 17, 4, 3, 5, 2 }
            //Output: 17 5 2

            int currentLeader = inputArray[inputArray.Length - 1];

            List<int> leaderList = new List<int>
            {
                inputArray[inputArray.Length - 1]
            };

            for (int i = inputArray.Length - 2; i > -1; i--)
            {
                if (inputArray[i] > currentLeader)
                {
                    currentLeader = inputArray[i];
                    leaderList.Add(inputArray[i]);
                    leaderList = leaderList.OrderByDescending(x => x).ToList();
                }
            }

            return leaderList.ToArray();
        }

        public int MinimumPlatforms(int[] arrivalTimes, int[] departureTimes)
        {
            //Given arrival and departure times of all trains that reach a railway station.
            //Find the minimum number of platforms required for the railway station so that no train is kept waiting.
            //Consider that all the trains arrive on the same day and leave on the same day.
            //Arrival and departure time can never be the same for a train but we can have arrival time of one train equal
            //to departure time of the other.At any given instance of time,
            //same platform can not be used for both departure of a train and arrival of another train.
            //In such cases, we need different platforms.
            
            return 0;
        }


    }
}
