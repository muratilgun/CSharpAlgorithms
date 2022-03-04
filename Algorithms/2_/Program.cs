using System;
using System.Linq;
namespace _2_
{
    class Program
    {
        static Boolean isUppercase(string s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean isLowercase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean isPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }



        static void Main(string[] args)
        {
            //Console.WriteLine(isUppercase("hello"));
            //Console.WriteLine(isUppercase("HELLO"));
            //Console.WriteLine(isLowercase("hello"));
            //Console.WriteLine(isLowercase("HELLO"));
            
            Console.WriteLine(isPasswordComplex("Hell0"));
            Console.WriteLine(isPasswordComplex("Hello"));
            Console.WriteLine(isPasswordComplex("HellO"));
            Console.WriteLine(isPasswordComplex("HeLlo"));
            Console.WriteLine(isPasswordComplex("hello"));
            Console.WriteLine(isPasswordComplex(" "));


        }
    }
}
