using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode_Decorator
{
    public abstract class Component {
        public abstract void Draw();
    }

    public class Decoratoree : Component
    {
        public string Title { get; set; }
        public Decoratoree() {
            Title = "Decoratoree";
        }

        public override void Draw()
        {
            Console.WriteLine(this.Title);
        }
    }


    public class Decorator : Component
    {
        public string Title { get; set; }
        public Decorator()
        {
            Title = "Decorator";
        }
        public Component comp { get; set; }
        public void SetComponent(Component c)
        {
            comp = c;
        }

        public virtual void OtherOpation()
        {
            Console.WriteLine("Other Opt");
        }
        public override void Draw()
        {
            OtherOpation();
            Console.WriteLine(this.Title);
            comp.Draw();
        }
    }

    public class Client
    {
        public void Test() {
            var deoratoree = new Decoratoree();
            var deorator = new Decorator();
            deorator.SetComponent(deoratoree);

            deorator.Draw();

        }
    }
}
