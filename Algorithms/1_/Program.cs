using System;

namespace _1_
{

    class Program
    {
        //Aşağıdaki metotta 
        // integer değer dönene 3 int parametre alan bir metot
        //A'nın B'den büyük olup olmadığını kontrol et.
        // B'nin A'dan büyük olup olmadığını kontrol et.
        // Her girişte birden fazla kontrol yapılıyor.

        #region İLK HALİ
        //static int findMaximum(int a, int b, int c)
        //{
        //    if (a > b)
        //    {
        //        if (a > c || a == c)
        //        {
        //            return a;
        //        }
        //    }
        //    if (b > c)
        //    {
        //        if (b > a || a == b)
        //        {
        //            return b;
        //        }
        //    }

        //    return c;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(findMaximum(1, 2, 3));
        //    Console.WriteLine(findMaximum(8, 8, 1));
        //    Console.WriteLine(findMaximum(3, 2, 3));
        //    Console.WriteLine(findMaximum(1, 1, 9));
        //    Console.WriteLine(findMaximum(1, 9, 9));
        //} 
        #endregion

        // Bunun yerine bir değişken kullanarak maksimum takip edilebilinir.
        // Tekrar integer geri döndüren 3int parametre alan bir metot oluşturulur.
        // Örneğin maximum a değeri ile kontrole başlasın. 51.s
        // sonra B ile karşılaştırsın. 52.s 
        // eğer B max'dan büyükse o zaman B'yi Maximum olarak alırım. 55.s
        //daha sonra C max'dan büyükmü kontrolü yaparım büyükse c'nin değerini max değişkenine atarım.
        // yani max değişkeni hem a'yı, hem b'yi, hem c'yi içerir. Daha sonra değeri döndürürüm.
        /*yukarıdaki algoritmadan herseferinde
         C kontrolüde yapmak zorundaydım. ama tek bir değer üzerinden gidince 
         buna gerek kalmadı. Çünkü değer zaten max değişkeninde depolanır.*/
        static int findMaximum2(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }

            if (c> max)
            {
                max = c;
            }

            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(findMaximum2(1, 2, 3));
            Console.WriteLine(findMaximum2(8, 8, 1));
            Console.WriteLine(findMaximum2(3, 2, 3));
            Console.WriteLine(findMaximum2(1, 1, 9));
            Console.WriteLine(findMaximum2(1, 9, 9));
        }








    }
}
