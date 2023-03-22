using System;
using System.Collections.Generic;

namespace Observersss
{
    public class MainApp
    {


        //public static void Main()
        //{

        //    ConcreteSubject s = new ConcreteSubject();
        //    s.Attach(new ConcreteObserver(s, "X"));
        //    s.Attach(new ConcreteObserver(s, "Y"));
        //    s.Attach(new ConcreteObserver(s, "Z"));

        //    s.SubjectState = "ABC";

        //    s.Notify();


        //    //s.Attach(new ConcreteObserver(s, "X"));
        //    //s.Attach(new ConcreteObserver(s, "Z"));

        //    s.SubjectState = "UML";

        //    s.Notify();

        //    Console.ReadKey();
        //}
    }


    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();


        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer item in _observers)
            {
                item.Update();
            }
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    class ConcreteObserver : Observer
    {
        private ConcreteSubject _concreteSubject;
        private string _name;
        private string observerstate;


        public ConcreteObserver(ConcreteSubject concreteSubject, string name)
        {
            this._concreteSubject = concreteSubject;
            this._name = name;
        }
        public override void Update()
        {
            observerstate = _concreteSubject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", _name, observerstate);
        }
    }

    internal class ConcreteSubject : Subject
    {
        public string SubjectState { get; internal set; }

        //internal void Attach(ConcreteObserver concreteObserver)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
