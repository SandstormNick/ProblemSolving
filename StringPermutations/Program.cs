//Given a string S. The task is to print all unique permutations of the given string in lexicographically sorted order.

//Example 1
//Input: ABC
//Output:
//ABC ACB
//BAC BCA
//CAB CBA
//Explanation:
//Given string ABC has permutations in 6 
//forms as ABC, ACB, BAC, BCA, CAB and CBA .

//Example 2
//Input: ABSG
//Output:
//ABGS ABSG AGBS AGSB ASBG ASGB  
//BAGS BASG BGAS BGSA BSAG BSGA  
//GABS GASB GBAS GBSA GSAB GSBA  
//SABG SAGB SBAG SBGA SGAB SGBA
//Explanation:
//Given string ABSG has 24 permutations.

//Your Task:  
//You don't need to read input or print anything.
//Your task is to complete the function find_permutaion() which takes the string S as input parameter
//and returns a vector of string in lexicographical order.

//string S = "ABC";
string S = "ABSG";
S = sortString(S);

List<string> stringList = new List<string>();

char[] charArray = S.ToCharArray();
find_permutaion(charArray, 0, charArray.Length - 1);

stringList.Sort(); //find_permutation is not returning it in lexicographical order though
foreach (string str in stringList)
{
    Console.WriteLine(str);
}

void find_permutaion(char[] arry, int i, int n)
{
    int j;
    if (i == n)
    {
        string temp = new string(arry);
        stringList.Add(temp);
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