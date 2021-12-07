using System;
using System.Collections.Generic;

namespace LinkedListUC8
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> L1 = new List<int>();
            L1.Add(56);
            L1.Add(30);
            L1.Add(70);
            L1.Add(99);

            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("----------------");
            int size = L1.Count;
            for (int i = 0; i < size; i++)
            {
                if (L1[i] == 30)
                {
                    L1.Insert(i + 1, 40);
                    break;
                }

            }

            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(L1.Contains(30));


        }
    }
    }

