using System;
using System.Collections.Generic;

namespace LinkedListUC10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>();
            L1.Add(56);
            L1.Add(30);
            L1.Add(40);
            L1.Add(70);
            L1.Add(40);

            
                foreach (var element in L1)
                {
                    Console.WriteLine(element);
                }

            Console.WriteLine("----------After----");
            int size = L1.Count;
            for (int i = 0; i < size; i++)
            {
                if (L1[i] == 40) 
                {
                    L1.RemoveAt(i);
                    break;
                }

            }

            Console.WriteLine("Size is " + L1.Count);
            foreach (var element in L1)
                Console.WriteLine("-------------After sorting -----------------");
            L1.Sort();
            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }



        }


    }
    }
    

