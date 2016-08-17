using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];

            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i , j);
            }

            Console.WriteLine("--------------------------------------");

            int[,] a = new int[5, 2] { {0, 0}, {1, 2}, {2, 4}, {3, 6}, {4, 8}};

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", i, j, a[i, j]);
                }
            }

            Console.WriteLine("--------------------------------------");

            int[][] b = new int[][] {new int[] {0, 0}, new int[] {1, 2}, new int[] {2, 4}, new int[] {3, 6}, new int[] {4, 8}};

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("b[{0}][{1}] = {2}", i, j, b[i][j]);
                }
            }
            
            Console.ReadKey();
        }
    }
}
