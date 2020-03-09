using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode_Singleton
{
    public class Singleton
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected Singleton() { }
        private static Singleton _instance;
        public static Singleton GetInstance() {
            if (_instance == null) {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    public class Client {
        public void Test() {
            var signleton = Singleton.GetInstance() ;

            signleton.Name = "张三";
            signleton.Age = 11;

            var signleton1 = Singleton.GetInstance();

            Console.WriteLine(signleton.Name);
            Console.WriteLine(signleton1.Age);
        }
    }
}
