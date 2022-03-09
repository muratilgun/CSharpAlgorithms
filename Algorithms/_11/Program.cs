using System;

namespace _11_
{
    class Program
    {
        /*Tüm içeriği sola kaydırmak için =>
         inputun ilk indeksini temp değişkeninde atıyorum. Bu casede temp = 1
         bir for döngüsü ile 
         inputtun i. indeksinden gelen değeri inputun i. bir sonraki indeksinin değeri yap 0. indekse 1. indeksin değeri yap. 1.ise 2. ...
         inputun son indeksinin değerini temp değişkeninin değeri olarak belirtiyorum.*/
        static void RotateArrayLeft(int[] input)
         {

            int temp = input[0];
            for (int i = 0; i < input.Length - 1; i++)
            {
                //inputtan i indeksinden gelen değeri inputun bir sonraki indeksinin değeri yap
                input[i] = input[i + 1] ;
            } // output : [2,3,4,5,6,6]

            input[input.Length - 1] = temp;
        }
        static void RotateArrayRight(int[] input)
        {
            int temp = input[input.Length - 1];
            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];

            }// output : [1,1,2,3,4,5]

            input[0] = temp;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //RotateArrayLeft(arr);
            RotateArrayRight(arr);
            Array.ForEach(arr, Console.WriteLine);


        }
    }
}
