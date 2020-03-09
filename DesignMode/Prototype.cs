using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode_Prototype
{
    public class Prototype: ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone() ; // 浅复制
        }
    }
    public class Client
    {
        public void Test() {
            var t1 = new Prototype();
            t1.Name = "张三";
            t1.Age = 12;

            var t2 = (Prototype)t1.Clone();

            Console.WriteLine(t1.Name);
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.Age);
        }
    }

}
