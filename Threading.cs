using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectOrientedConcepts
{
    //Thread – A Thread is a lightweight process that is responsible for executing application code. A process has at least one thread which is commonly called the main thread which actually executes the application code.
    //A single process can have multiple threads.
    //A process can start multiple threads. Every process starts with a single thread called the primary thread. You can create n number of threads in a process.
    //Threads share the resources allocated to the process. A process is the parent and threads are his children.

    public class Mehtods
    {
        static object _lock = new object();
        public static int count = 0;

        public static void PrintNumbees()
        {
            for (int i= 0; i < 15; i++)
            {
                Console.Write(" {0} ", i);
            }
        }

        //protect shared resources by locks
        public static void AddOneMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    count++;
                }
            }
        }
    }
    public class Threading
    {       

        public void NormalWayToCreateThread() {
            Thread t1 = new Thread(Mehtods.PrintNumbees);  //this get internally converted into new Thread(new ParameterizedThreadStart(Mehtods.PrintNumbees) 
            t1.Start();
        }
        //ParameterizedThreadStart : When we need to pass data to the thread function then in such situations we need to use the ParameterizedThreadStart delegate.

        public void CreateThreadByThreadStartDelegate()
        {
           Thread t2 = new Thread( new ThreadStart(Mehtods.PrintNumbees)); //delegate needs an entry point to execute the methd from thread
            t2.Start();
        }


        //Thread.Join vs Thread.IsAlive

        //call AddOneMillion for
        public void DemoLockingResourceByLock()
        {
                Thread thread1 = new Thread(Mehtods.AddOneMillion);
                Thread thread2 = new Thread(Mehtods.AddOneMillion);
                Thread thread3 = new Thread(Mehtods.AddOneMillion);

                thread1.Start();
                thread2.Start();
                thread3.Start();

                thread1.Join();
                thread2.Join();
                thread3.Join();

                Console.WriteLine("Count = " + Mehtods.count);
                Console.ReadLine();
        }
    }
}
