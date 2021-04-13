using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.SingletonDP

{

    public sealed class ThreadSafeUsingEagerLoading : ISingletoneObj
    {
        private static int counter = 0;
        private ThreadSafeUsingEagerLoading()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        private static readonly ThreadSafeUsingEagerLoading singleInstance =
                                               new ThreadSafeUsingEagerLoading();

        public static ThreadSafeUsingEagerLoading GetInstance
        {
            get
            {
                return singleInstance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
