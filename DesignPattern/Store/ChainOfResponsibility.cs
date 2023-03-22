using System;
using System.Collections.Generic;

namespace Chainsadjh
{


    public class MainApp
    {

        public abstract class Handler
        {
            protected Handler _successor;
            public void SetSuccessor(Handler successor)
            {
                this._successor = successor;
            }
            public abstract void HandleRequest(int request);
        }


        //public static void Main()
        //{

        //    Handler h1 = new ConcreteHandler1();
        //    Handler h2 = new ConcreteHandler2();
        //    Handler h3 = new ConcreteHandler3();
        //    h1.SetSuccessor(h2);
        //    h2.SetSuccessor(h3);


        //    int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };


        //    foreach (var item in requests)
        //    {
        //        h1.HandleRequest(item);
        //    }

        //    Console.ReadKey();
        //}
    }

    internal class ConcreteHandler1 : MainApp.Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handle request {1}", this.GetType().Name, request);
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }

    internal class ConcreteHandler2 : MainApp.Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handle request {1}", this.GetType().Name, request);
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }

    internal class ConcreteHandler3 : MainApp.Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handle request {1}", this.GetType().Name, request);
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
