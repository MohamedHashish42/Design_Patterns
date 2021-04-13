using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.SingletonDP
{
    public sealed class ThreadSafeUsingLazyKeyword : ISingletoneObj
    {
        private static int counter = 0;
        private ThreadSafeUsingLazyKeyword()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly Lazy<ThreadSafeUsingLazyKeyword> Instancelock =

                  new Lazy<ThreadSafeUsingLazyKeyword>(() => new ThreadSafeUsingLazyKeyword());
        public static ThreadSafeUsingLazyKeyword GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
