using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class StringPermutations
    {
        List<string> permutations { get; set; }

        StringPermutations()
        {
            permutations = new List<string>();
        }

        List<string> find_permutation(string stringInput)
        {
            stringInput = sortString(stringInput);

            char[] charArray = stringInput.ToCharArray();
            find_permutaion(charArray, 0, charArray.Length - 1);

            permutations.Sort(); //find_permutation is not returning it in lexicographical order though

            return permutations;
        }
        private void find_permutaion(char[] arry, int i, int n)
        {
            int j;
            if (i == n)
            {
                string temp = new string(arry);
                permutations.Add(temp);
            }
            else
            {
                for (j = i; j <= n; j++)
                {
                    Swap(ref arry[i], ref arry[j]);
                    find_permutaion(arry, i + 1, n);
                    Swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }


        string sortString(string stringInput)
        {
            stringInput = string.Concat(stringInput.OrderBy(c => c));
            return stringInput;
        }
    }
}
