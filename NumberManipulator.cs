using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y) 
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();

            int a = 100;
            int b = 200;

            Console.WriteLine("Before, a: {0}", a);
            Console.WriteLine("Before, b: {0}", b);

            n.swap(ref a, ref b);

            Console.WriteLine("After, a: {0}", a);
            Console.WriteLine("After, b: {0}", b);

            Console.ReadLine();
        }
    }
}
