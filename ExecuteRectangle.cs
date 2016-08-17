using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApplication
{
    class Rectangle
    {
        // member variable
        internal double length;
        internal double width;

        public void AcceptDetails()
        {
            Console.WriteLine("Please enter length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
