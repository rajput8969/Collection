using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class deDictionaryDemn
    {
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\nin deDictionarydeno");

            Dictionary<int, string> dictionary = new Dictionary<int, string>(); dictionary.Add(100, "Amit");
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(182, "Vijay");

            Console.WriteLine("Access value using key(key=100):" + dictionary[100]);

            Console.WriteLine("\nIterating Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("key =" + element.Key + " & Value = " + element.Value);
            }
        }
    }
}