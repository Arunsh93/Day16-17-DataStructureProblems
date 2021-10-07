using System;

namespace InsertionSort
{
    class InsertionSort 
    {
        public static void InsertSort(IComparable[] strArray)
        {
            int i, j;
            for(i = 1; i<strArray.Length; i++)
            {
                IComparable value = strArray[i];
                j = i - 1;
                while((j>=0) && (strArray[j].CompareTo(value) > 0))
                {
                    strArray[j + 1] = strArray[j];
                    j--;
                }
                strArray[j + 1] = value;
            }
        }
        static void Main(string[] args)
        {
            string[] names = { "Arun", "Jyotiprasad", "Nagu", "Bharath", "Siddu", "Muttu" };
            InsertSort(names);
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
