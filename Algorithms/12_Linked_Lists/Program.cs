using System;
using System.Collections.Generic;

namespace _12_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> listy = new LinkedList<string>();
            // AddLast
            // AddFirst
            listy.AddLast("Ahmet");
            listy.AddLast("Murat");
            listy.AddLast("Amila");
            listy.AddLast("Sarah");

            Console.WriteLine(listy.Contains("Niyazi"));
            Console.WriteLine(listy.Count);
            listy.RemoveFirst();
            foreach (string s in listy)
            {
                Console.Write(s + "->");
            }

            Console.WriteLine();
            
        }
    }
}
