using System;
using System.Collections.Generic;

namespace LinkedListUC9
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

            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("----------------");
            Console.WriteLine("----------After----");
            int size = L1.Count;
            for (int i = 0; i < size; i++)
                {
                    if (L1[i] == 30)
                        if (L1[i] == 40) 
                    {
                        L1.Insert(i + 1, 40);
                        L1.RemoveAt(i);
                        break;
                    }


                }

            Console.WriteLine("Size is " + L1.Count);
            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }



        }
    }
    }

