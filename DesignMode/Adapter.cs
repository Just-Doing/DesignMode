using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode
{
    public class Adapter
    {
        public void Excute()
        {
            Console.WriteLine("这是 目标 事件");
        }
    }

    // 适配器
    public class Target
    {
        Adapter adapter;
        public Target(Adapter apapter) {
            this.adapter = apapter;
        }

        public void NewFun() {
            Console.WriteLine("干点事情。。---在目标方法前");
            this.adapter.Excute();
            Console.WriteLine("干点事情。。---在目标方法后");
        }

    }
}
