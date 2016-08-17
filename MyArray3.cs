using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayApplication3
{
    class ParamArray
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }

            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParamArray app = new ParamArray();
            int sum = app.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();
        }
    }
}
