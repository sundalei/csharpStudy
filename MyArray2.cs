using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayApplication2
{
    class MyArray
    {
        double getAverage(int[] arr, int size)
        {
            double avg;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }

            avg = (double)sum / size;
            return avg;
        }

        static void Main(string[] args)
        {
            MyArray app = new MyArray();

            int[] balance = new int[] { 1000, 2, 3, 17, 50};
            double avg;

            avg = app.getAverage(balance, 5);

            Console.WriteLine("Average is: {0}", avg);
            Console.ReadKey();
        }
    }
}
