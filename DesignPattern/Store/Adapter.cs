
using System;

namespace Facade
{

    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("Method from Adaptee class");
        }
    }


    class Adapter : ITarget
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void MethodA()
        {
            _adaptee.MethodB();
        }
    }

    interface ITarget
    {
        public void MethodA();
    }


    class Clinet
    {
        private ITarget target;
        public Clinet(ITarget t)
        {
            target = t;
        }

        public void Request()
        {
            target.MethodA();
        }

    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        ITarget target = new Adapter(new Adaptee());

    //        Clinet client = new Clinet(target);

    //        client.Request();

    //        Console.WriteLine("Hello World!");
    //    }
    //}
}
