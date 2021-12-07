using System;
using System.Collections.Generic;

namespace LinkedListUC5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            foreach(int value in linkedList)
            {
                Console.WriteLine(value);
            }
            linkedList.RemoveFirst();
            Console.WriteLine("After removing the LinkedList Will be:");
            foreach(int value in linkedList)
            {
                  Console.WriteLine(value);
            }

        }
    }
}
