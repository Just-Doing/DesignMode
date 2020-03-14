using System;

namespace DesignMode
{
    class Program
    {
        static void Main(string[] args)
        {
            new DesignMode_Bridge.Client().Test();
            Console.ReadKey();
        }
    }
}
