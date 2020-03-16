using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode_Composite
{
    public class Component
    {
        public Component(string t){
            this.Title = t;
        }
        public string Title { get; set; }
        public List<Component> Childrent = new List<Component>();

        public virtual void Operation()
        {
            Console.WriteLine(this.Title);
            foreach (var c in this.Childrent)
            {
                c.Operation();
            }
        }
    }


    public class Composite : Component
    {
        public Composite(string t) : base(t)
        {
        }

        public void AddComp(Component c)
        {
            this.Childrent.Add(c);
        }

        public void Remove(Component c)
        {
            this.Childrent.Remove(c);
        }

    }


    public class Client {
        public void Test() {
            var composite = new Composite("composite");

            var component = new Component("node1");
            var leaf1 = new Component("leaf");
            var component2 = new Component("node3");
            component2.Childrent.Add(leaf1);
            var component3 = new Component("node4");
            var leaf2 = new Component("leaf");
            component2.Childrent.Add(leaf2);

            composite.Childrent.Add(component);
            composite.Childrent.Add(component2);
            composite.Childrent.Add(component3);

            composite.Operation(); // 一次执行，  自动递归到底， 非常方便
        }
        
    }

}
