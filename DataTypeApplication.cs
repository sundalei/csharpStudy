using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of long: {0}", sizeof(long));

            Console.WriteLine("----------------------------------------");
            dynamic a = 20;
            Console.WriteLine(a);

            Console.WriteLine("----------------------------------------");
            string str = @"<script type=""text/javascript"">
    <!--
    -->
    </script>";
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
