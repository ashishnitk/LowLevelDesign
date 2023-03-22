using System;
using System.Threading.Tasks;

namespace HelloWorld
{

    sealed class Singleton
    {
        private static int counter = 0;

        private static readonly object obj = new object();

        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }

                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("counter value " + counter);
        }

        public void PrintDertails(string msg)
        {
            Console.WriteLine(msg);
        }

    }


    class Program2
    {

        public static void F1()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDertails("From Employee");
        }

        public static void F2()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDertails("From Student");
        }

        //static void Main(string[] args)
        //{
        //    // clinet
        //    //Singleton fromEmployee = Singleton.GetInstance;
        //    //fromEmployee.PrintDertails("From Employee");

        //    //Singleton fromStudent = Singleton.GetInstance;
        //    //fromStudent.PrintDertails("From Student");

        //    Parallel.Invoke(
        //        () => F1(),
        //        () => F2());


        //    Console.WriteLine("Hello World!");
        //}
    }
}
