using System;
using Linq;

namespace Linq{
    public  delegate void MulDelegate(double width, double length);

    public static class MulticastDelegate{

        public static void Area(double width, double length)
        {
            Console.WriteLine("Area is - " +(width*length));
        }

        public static void Circumference(double width, double length)
        {
            Console.WriteLine("Circumference is - " + 2*(width+length));
        }

    }
}