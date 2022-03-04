using System;

namespace _4_
{
    class Program
    {
        // Bu şekilde kısaca istenilen string ifadeyi aratabilsek bile, bu verimli değildir.
        //Console.WriteLine("Hello World!".ToLower().Contains("ll"));
        // bilinmeyen string bir ifadeyi ararken iki farklı algoritma kurabiliriz.
        // 1. seçenek foreach döngüsünden faydalanılabilinir.
        //2. seçenek for döngüsünden faydalanılabilinir For kullanılarak hem karakterin konumuna hemde kendisine ulaşabilinir.
        //Hangisinin daha iyi olduğu aranılan veya dizeden ayrıştırılması gerekenlere göre değişebilir

        static void ParseContents(string s)
        {
            Console.WriteLine("Option 1");
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Option 2");
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }

        }

        static Boolean IsAtEvenIndex(string s, char item)
        {
            // gelen index numarası ve 

            // sadece çift indexlerin kontrolü zaman kazanmak için 2 ye bölünüp bir ekleniyor çünkü 0dan başlattım
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }

            for (int i = 0; i < s.Length / 2 + 1; i=i+2)
            {
                if (s[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            //ParseContents("murat");
            String input = "HeLLo";
            Console.WriteLine(IsAtEvenIndex(input, 'L'));
            Console.WriteLine(IsAtEvenIndex(input, 'T'));
            Console.WriteLine(IsAtEvenIndex(input, 'H'));
            Console.WriteLine(IsAtEvenIndex("", 'H'));
            Console.WriteLine(IsAtEvenIndex(null, 'H'));
        }
    }
}
