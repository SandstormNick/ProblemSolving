namespace Problems
{
    public class ReverseWordsInString
    {
        public string reverseWords(string inputString)
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
    }
}