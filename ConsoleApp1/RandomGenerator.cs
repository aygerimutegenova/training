using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RandomGenerator
    {
        public void Print() {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; ++i)
            {
                Random rnd = new Random();
                a[i] = rnd.Next(5);
                Console.WriteLine(a[i]);
            }

           
        }
    }
}
