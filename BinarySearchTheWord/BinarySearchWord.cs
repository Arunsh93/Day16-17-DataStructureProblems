using System;

namespace BinarySearchTheWord
{
    class BinarySearchWord
    {
        static int BinarySearchString(string[] stringArray, string str)
        {
            int i = 0, j = stringArray.Length - 1;
            while(i <= j)
            {
                int n = i + (j - i) / 2;
                int result = str.CompareTo(stringArray[n]);

                if(result == 0)
                {
                    return n;
                }
                if(result > 0)
                {
                    i = n + 1;
                }
                else
                {
                    i = n - 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            string[] stringArray = { "Contribute", "geeks", "ide", "Jyotiprasad" };
            string x = "ide";
            int result = BinarySearchString(stringArray, x);
            if(result == -1)
            {
                Console.WriteLine("Element Not Present");
            }
            else
            {
                Console.WriteLine("Element is found at index " + result);
            }
        }
    }
}
