using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class deStackDeno
    {
        private static void dostackDemo()
        {

            Console.WriteLine("\nin dostackDemo");
            //Creating Stack
            Stack<string> stack = new Stack<string>();

            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");

            string pop = stack.Pop();

            // Iterating stack elements foreach (var element in stack)
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Poped element: " + pop);
        }
    }
}
