using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.SingletonDP
{
    public sealed class ThreadSafeDoubleChecked : ISingletoneObj
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private ThreadSafeDoubleChecked()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static ThreadSafeDoubleChecked instance = null;
        public static ThreadSafeDoubleChecked GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeDoubleChecked();
                        }
                    }
                }

                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}


