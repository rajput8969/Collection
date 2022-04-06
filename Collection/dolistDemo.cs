using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class delistDemo
    {
        private static void dolistDemo()
        {

            Console.WriteLine("\nIn dolistDemo");
            //Creating List

            List<string> list = new List<string>();
            //Adding object to the list

            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            // Iterating list elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}