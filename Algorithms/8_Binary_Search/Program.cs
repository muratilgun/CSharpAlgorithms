using System;

namespace _8_Binary_Search
{
    class Program
    {
        /*implementasyon için
         Dizinin sıralandığını varsayıyorum. Eğer öyle değilse sıralayıp normalize 
         etmek gerekir.(sorting yani sıralama algoritması daha uzun sürebilir.)
         ilk adım min ve max indexleri için değişkenleri oluşturmaktır.
         min maksimumdan büyük veya eşit olana kadar arama yapmasını istiyeceğim
         bunun için bir while looptan yararlanıyorum. eğer item bulunmaz ise false dönecek satır 36
         dizinin orta noktasını tespit etmek için integer bi mid değişkeni tanımlıyorum. 
         min ve max değerlerini toplayıp ikiye bölüyorun. Ve mid değerine atıyorum. satır 21
         sonra bu öğenin aranılan öğeye eşit olup olmadığını kontrol ediyorum. Eğer eşitse sayı bulunmuş olur true dönüyorum. satır 23-24
         ilk if'i atlarsa aranan öğenin(item) dizini başına doğru yakın olan kısımda olup olmadığına bakıyorum.
         eğer item dizenin ortasındaki sayıdan küçükse başa doğru olan kısmı aramaya devam ederim. satır 30 
         eğer item dizenin ortasındaki sayıdan büyükse sona doğru olan kısmı aramaya devam ederim. satır 35
         C# 'ın BinarySearch için yerleşik bir fonksiyonu vardır. satır 47
         */
        static Boolean BinarySearch(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (item == inputArray[mid]) {
                    return true;
                }
                else if(item < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(BinarySearch(arr,5));
            Array.BinarySearch(arr, 5);
        }
    }
}
