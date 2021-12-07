using System;
using System.Collections.Generic;

namespace LinkedListUC6
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            foreach (int value in linkedList)
            {
                Console.WriteLine(value);
            }
            linkedList.RemoveLast();
            Console.WriteLine("After removing... The LinkedList Will be:");
            foreach (int value in linkedList)
            {
                Console.WriteLine(value);
            }

        }
    }
}
