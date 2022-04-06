using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class doQueueDemo
    {
        private static void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");

            //Creating Queue

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");
            // Iterating Queue elements

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element: " + dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element:");

            // Iterating Queue elements using Enumerator

            Queue<string>.Enumerator enumerator = queue.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}

