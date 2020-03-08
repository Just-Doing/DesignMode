using System;

namespace DesignMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app1 = new Application1();
            Application app2 = new Application2();
            Client client = new Client(app2);
            client.Excute();
            Console.ReadKey();
        }
    }
}
