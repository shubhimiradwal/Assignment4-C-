using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a1 = new List<string>() { "Boat", "house", "cat", "river", "cupboard" };
            for (int i = 0; i < a1.Count; i++)
            {
                string a2 = a1[i] + "s";
                Console.WriteLine(a2);

            }
            a1[1] = a1[1].Replace("house","home");
            Console.WriteLine(a1[1]);
            a1.Add("shubhii");
            a1.Add("purvi");

            for (int i= 0;i< a1.Count;i++)
            {
                if (a1[i].Length == 7)
                {
                    Console.WriteLine(a1[i]);
                }
            }
            a1.Reverse();
            foreach (string value in a1)
            {
                Console.WriteLine(value);
            }

            a1.Sort();
            
            foreach(string value in a1)
            {
                Console.WriteLine(value);
            }

            
            

        }
    }
}
