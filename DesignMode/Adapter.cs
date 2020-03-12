using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode
{
    public class Target
    {
        public void Excute()
        {
            Console.WriteLine("这是 目标 事件");
        }
    }

    // 适配器
    public class Adapter {
        Target target;
        public Adapter(Target t) {
            this.target = t;
        }

        public void NewFun() {
            Console.WriteLine("干点事情。。---在目标方法前");
            this.target.Excute();
            Console.WriteLine("干点事情。。---在目标方法后");
        }

    }
}
