using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableApplication
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine("Show nullable values: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("Show nullable boolean: {0}", boolval);

            Console.WriteLine("----------------------------------------");

            double? number1 = null;
            double? number2 = 3.14157;
            double? number3;

            number3 = number1 ?? 5.34;
            Console.WriteLine("Value of number3: {0}", number3);

            number3 = number2 ?? 5.34;
            Console.WriteLine("Value of number3: {0}", number3);

            Console.ReadKey();
        }
    }
}
