using System;

namespace _10_Reverse_Array
{
    class Program
    {
        /*Ters çevirmek istediğim inputumu int array değişkenin içerisine atıyorum. -Satır 11
          gelen dizini for döngüsü ile dönüyorum satır 12
          reversed değişkenin i. indexine gelen input'un i eksi eksi birinci değerini atıyorum.
          örn : i=0 reverserved[0] = input[6-0-1]  output reversed[0] = 6
              : i=1 reverserved[1] = input[6-1-1]  output reversed[1] = 5 ...
          şeklinde gelen arrayi tersine döndürebilirim.
          Her hangibir içerik eklenmediğinden veya kaldırılmadığından bu algoritma yerindede yapılabilinir.
          array içerisindeki öğeleri ters sıralı gönderebilirim. Bu algoritmada sadece yarısını tekrarlamak yeterli olacaktır.
          
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

        static void ReverseInPlace(int[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Array.ForEach(Reverse(arr),Console.WriteLine);
            ReverseInPlace(arr);
            Array.ForEach(arr,Console.WriteLine);
        }
    }
}
