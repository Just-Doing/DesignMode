using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode
{
    public abstract class ProductA { public string title { get; set; } }
    public abstract class ProductB { public string title { get; set; } }
    public class ProductA1 : ProductA
    {
        public ProductA1() { title = "ProductA1"; }
    }
    public class ProductA2 : ProductA
    {
        public ProductA2() { title = "ProductA2"; }
    }

    public class ProductB1 : ProductB
    {
        public ProductB1() { title = "ProductB1"; }
    }
    public class ProductB2 : ProductB
    {
        public ProductB2() { title = "ProductB2"; }
    }


    public abstract class Application{
        abstract public ProductA CreateProductA();
        abstract public ProductB CreateProductB();
    }

    public class Application1 : Application
    {
        public override ProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB1();
        }
    }


    public class Application2 : Application
    {
        public override ProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB2();
        }
    }


    public class Client {
        public Application app;
        public Client(Application app) {
            this.app = app;
        }

        public void Excute()
        {
            Console.WriteLine(app.CreateProductA().title);
            Console.WriteLine(app.CreateProductB().title);
        }
    }
}
