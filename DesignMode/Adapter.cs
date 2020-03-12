using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode
{
    #region 单继承
    public class TargetA
    {
        public virtual void Excute()
        {
            Console.WriteLine("这是 目标 事件");
        }
    }

    public class TargetA_Adapter : TargetA
    {
        public override void Excute()
        {
            Console.WriteLine("干点事情。。---在目标方法前");
            base.Excute();
            Console.WriteLine("干点事情。。---在目标方法后");
        }

    }

    #endregion


    #region 多接口集成

    public class TargetB 
    {
        public virtual void Excute()
        {
            Console.WriteLine("这是 目标 事件");
        }
    }

    public abstract class Adapter: TargetB
    {
        public abstract void BeforeDoSomething();
        public abstract void EndDoSomething();
        public override void Excute()
        {
            BeforeDoSomething();
            base.Excute();
            EndDoSomething();
        }
    }

    public class TargetB_Adapter : Adapter
    {
        public override void BeforeDoSomething()
        {
            Console.WriteLine("干点事情。。---在目标方法前");
        }

        public override void EndDoSomething()
        {
            Console.WriteLine("干点事情。。---在目标方法后");
        }
    }
    #endregion
}
