//https://www.geeksforgeeks.org/must-do-coding-questions-for-companies-like-amazon-microsoft-adobe/

//Given a String S, reverse the string without reversing its individual words. Words are separated by dots.

//Example 1
//Input:
//S = i.like.this.program.very.much
//Output: much.very.program.this.like.i

//Your Task:
//    You dont need to read input or print anything. 
//   Complete the function reverseWords() which takes string S as 
//        input parameter and returns a string containing the words in reversed order. 
//    Each word in the returning string should also be separated by '.' 
//-------------------------------------------------------------------------------------

//string S = "i.like.this.program.very.much.promise";
//string S = "i.like.this.program.very.much.promise";
string S = "mno.pqr";
S = reverseWords(S);

Console.WriteLine(S);



string reverseWords(string inputString)
{
    string[] stringArray = inputString.Split('.');
    int midpoint = stringArray.Length / 2;

    for (int i = 0; i < midpoint; i++)
    {
        string temp1 = stringArray[i];
        string temp2 = stringArray[stringArray.Length - (1 + i)];

        stringArray[i] = temp2;
        stringArray[stringArray.Length - (1 + i)] = temp1;
    }

    inputString = string.Join('.', stringArray);

    return inputString;
}