using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            i = (int)d;
            Console.WriteLine(i);

            Console.WriteLine("--------------------------");

            int integer = 75;
            float f = 53.005f;
            double doubleValue = 2345.7652;
            bool b = true;

            Console.WriteLine(integer.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(doubleValue.ToString());
            Console.WriteLine(b.ToString());

            Console.ReadKey();
        }
    }
}
