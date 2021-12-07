using System;
using System.Collections.Generic;

namespace LinkedListUC4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>();
            L1.Add(56);
            L1.Add(30);
            L1.Add(70);
            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }

            L1.Insert(1, 30);
            Console.WriteLine("After inserting 30 between 56 and 70-------------------------");
            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }
        }
    }
}

