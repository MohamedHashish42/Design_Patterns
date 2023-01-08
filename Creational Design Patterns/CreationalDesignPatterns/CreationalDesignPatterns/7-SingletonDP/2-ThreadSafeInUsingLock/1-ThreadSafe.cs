using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.SingletonDP
{
    public sealed class ThreadSafe : ISingletonObj
    {
        private static int counter = 0;

        private static readonly object Instancelock = new object();

        private static ThreadSafe instance = null;
        private ThreadSafe()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public static ThreadSafe GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafe();
                    }
                    return instance;
                }
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}


