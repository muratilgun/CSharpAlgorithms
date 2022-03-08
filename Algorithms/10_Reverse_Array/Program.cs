using System;

namespace _10_Reverse_Array
{
    class Program
    {
        /*Ters çevirmek istediğim inputumu int array değişkenin içerisine atıyorum. -Satır 11
          gelen dizini for döngüsü ile dönüyorum satır 12
          gelen arrayin 
          
          */
        static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];
            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];

            }
            return reversed;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Array.ForEach(Reverse(arr),Console.WriteLine);
        }
    }
}
