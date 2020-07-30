using System;
using System.Linq;

namespace Linq{
    public  delegate void AddDelegate(int a, int b);

    public static class DelegateDemo
    {
        public static void Add(int a , int b)
        {
            Console.WriteLine("Adding Two Numbers is - " +(a+b));
        }
    }
}