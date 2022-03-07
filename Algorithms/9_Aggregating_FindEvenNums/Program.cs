using System;
using System.Collections;

namespace _9_Aggregating_FindEvenNums
{
    class Program
    {
        /*Sadece çift sayıları dönen bir method yazıyorum.
          bulduğum sonuçları tutacağım bir değişken oluşturuyorum. satır 13
          1. arraydeki çift sayıları buluyorum. satır 16
             array içerisinde bulduğum sayıları result değişkenine ekliyorum. satır 21
          2. arraydeki çift sayıları buluyorum. satır 25
             array içerisinde bulduğum sayıları result değişkenine ekliyorum. satır 29
           result değişkenin int[] array'e dönüştürüyorum. ve return ediyorum. satır 35
         NOT : .ToArray(typeof(int)); kısmında result'ın integer değer aldığını belirtiyorum.
          */
        static int[] FindEvenNums(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();
          
            foreach (int num in arr1)
            {
                if (num% 2 == 0) {
                    result.Add(num);
                }
            }

            foreach (int num in arr2)
            {
                if (num %2 == 0) {
                    result.Add(num);
                }
            }

            return (int[])result.ToArray(typeof(int));

        }
        static void Main(string[] args)
        {
            int[] arr1 = { -8, 2, 3, -9, 11, -20 };
            int[] arr2 = { 0, -2, -9, -39, 39, 10, 7 };
            int[] evenArr = FindEvenNums(arr1, arr2);
           Array.ForEach(evenArr,Console.WriteLine);
        }

    }
}
