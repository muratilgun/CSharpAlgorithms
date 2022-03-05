using System;
using System.Text;

namespace _6_
{
    class Program
    {
        //Challenge
        // Bir cümledekki kelimelerin yeri aynı kalacak ama kelimeleri tersine çeviren bir algoritma oluştur
        // Input:string, output kelime tersine çevrilmiş halde veren string
        // Noktalama işareti olmayacak ve her kelime boşluklarla ayrılmış olacaktır.
        // Büyük harf büyük olarak kalmalıdır.
        /*Geliştirmeye dair notlar  = 2 farklı iş 2 farklı metod içerisinde yapılır
         İlk önce parametrenin boş gelmesi ihtimaline karşı model doğrulaması işlemi yazılır. İstenildiği gibi bir input yoksa direk geri döndürülür. İşleme dahil edilmez Satır 19-22
        - Son sonucu tutacak bir değişken oluşturulur. Bu StringBuilder olarak seçildi çünkü sonuç adım adım oluşuyor.  Satır 30
        - inputdaki her kelime " " boşluk baz alınarak parçalanır.  Satır 31
        - Parçalanan her kelime bir string[] de tutulur. Satır 31
        - arrayin uzunluğu kadar tekrar edecek bir for döngüsü yazılır. Satır 32
        - daha sonra arrayin her indexini tersine çevirecek bir reverse metodu yazılır. Satır 44-54 
        - for döngüsü içerisinde arrayin ilgili index değerini tersine çevirdikten sonra val değerinin içerisine atarım Satır 34
        - Son sonuca çevrilen kelimeyi dahil ederim. Satır 36
        - Split ederken kelimelerin arasındaki boşlukları aldığım için tekrar her arr indexini tersine çevirdikten sonra sonuca boşluk eklerim. Satır 41
        - son index üyesinden sonra boşluk eklemeye gerek yok. o yüzden bir if bloğu ile boşluk atmasını engellerim Satır 40
        - son olarak oluşturmuş olduğum result değerini stringe dönüştürerek geri döndürürüm
        - bu şekilde cümle içerisindeki kelimelerin yeri değişmeden her öğenin tersine döndüğü bir algoritma elde etmiş olurum.
         */

        static String ReverseEachWord(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            String[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                string val = Reverse(arr[i]);
                result.Append(val);
                //result.Append(Reverse(arr[i]));
                if (i != arr.Length - 1)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }

        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Merhaba murat burada çalıştı"));
        }
    }
}
