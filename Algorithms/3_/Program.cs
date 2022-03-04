using System;

namespace _3_
{
    class Program
    {
        static string NormalizeString(String input)
        {
            return input.ToLower().Trim().Replace(",", "");
            //string lowercased =  input.ToLower();
            //string trimed = lowercased.Trim();
            //return trimed.Replace(",", "");

        }
        static void Main(string[] args)
        {
            Console.WriteLine(NormalizeString("Hello There, BUDDY         "));
        }
    }
}
