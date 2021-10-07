using System;

namespace AnagramProblem
{
    class Anagram
    {
        static void Main(string[] args)
        {
            string str1 = "Race";
            string str2 = "Care";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if(str1 == str2)
            {
                Console.WriteLine("Both Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Both strings are not anagram");
            }
        }
    }
}
