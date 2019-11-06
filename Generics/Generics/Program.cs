using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var nonGenericCollection = new ArrayList();
            nonGenericCollection.Add(4);
            nonGenericCollection.Add(4);
            nonGenericCollection.Add(4);
            nonGenericCollection.Add("str");

            Console.WriteLine("Print ArrayList");
            foreach (var x in nonGenericCollection)
            {
                Console.WriteLine(x);
            }

            //var GenericCollection = new List<int>();
            //GenericCollection.Add(4);
            //GenericCollection.Add(4);
            //GenericCollection.Add(4);
            //GenericCollection.Add("str");

            //Console.WriteLine("Print ArrayList");
            //foreach (var x in nonGenericCollection)
            //{
            //    Console.WriteLine(x);
            //}
        }
    }
}
