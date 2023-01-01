//Given a String S, reverse the string without reversing its individual words. Words are separated by dots.

//Example 1
//Input:
//S = i.like.this.program.very.much
//Output: much.very.program.this.like.i

string S = "i.like.this.program.very.much.promise";
S = reverseWords(S);

Console.WriteLine(S);



string reverseWords(string inputString)
{
    string[] stringArray = inputString.Split('.');
    int midpoint = stringArray.Length / 2;

    for (int i = 0; i < midpoint; i++)
    {
        string temp1 = stringArray[i];
        string temp2 = stringArray[stringArray.Length - 1];

        stringArray[i] = temp2;
        stringArray[stringArray.Length - 1] = temp1;
    }

    inputString = string.Join('.', stringArray);

    return inputString;
}