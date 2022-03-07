
using System;

namespace _7_
{
    class Program
    {
        // linear search yada sequential search(sıralı arama)
        static Boolean LinearSearch(int[] input, int n)
        {
            foreach (int current in input)
            {
                if (n == current)
                {
                    return true;
                }
            }
            
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(LinearSearch(arr, 4));
            //Console.WriteLine(LinearSearch(arr, 8));

            //ilgili koşulun sağlanıp sağlanmadığına bakar ve kendisini geri döner
            int item = Array.Find(arr,element => element == 3);
            Console.WriteLine(item);

            //koşulun sağlanıp sağlanmadığına bakar ver array geri döner. 
            int[] items = Array.FindAll(arr, element => element >= 5);
            // geri dönen dizinin her birini ForEach ile yazdırdım.
            Array.ForEach(items, Console.WriteLine);

        }
    }
}
