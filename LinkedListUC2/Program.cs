using System;
using System.Collections.Generic;

namespace LinkedListUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(70);
            linkedList.AddLast(30);
            linkedList.AddLast(56);
            foreach(int item in linkedList)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
