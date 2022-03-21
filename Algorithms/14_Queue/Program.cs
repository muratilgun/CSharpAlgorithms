using System;
using System.Collections.Generic;



namespace _14_Queue
//First in First out
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23);

            int removedItem = queue.Dequeue(); //1
            Console.WriteLine(removedItem);
            Console.WriteLine(queue.Dequeue()); //8
            Console.WriteLine(queue.Peek());
            int current;
            while (queue.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }
        }
    }
}
