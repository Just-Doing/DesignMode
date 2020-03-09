using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode_Singleton
{
    // 懒汉模式 线程安全 效率低
    public class Singleton
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private Singleton() { }
        private static Singleton _instance;
        public static Singleton GetInstance() {
            if (_instance == null) {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    // 饿汉模式 线程安全 效率高
    public class Singleton1
    {
        //    使用final修饰是防止被继承
        private static Singleton1 singleton = new Singleton1();
        private Singleton1() { }
        public static Singleton1 getInstance()
        {
            return singleton;
        }
    }


    public class Client
    {
        public void Test()
        {
            var signleton = Singleton.GetInstance();

            signleton.Name = "张三";
            signleton.Age = 11;

            var signleton1 = Singleton.GetInstance();

            Console.WriteLine(signleton.Name);
            Console.WriteLine(signleton1.Age);
        }
    }
}
