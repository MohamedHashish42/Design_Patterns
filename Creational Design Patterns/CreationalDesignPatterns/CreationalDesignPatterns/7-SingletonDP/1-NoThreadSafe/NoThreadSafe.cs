using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.SingletonDP
{ 
    public sealed class NoThreadSafe
    {
        private static int counter = 0;

        private static NoThreadSafe instance = null;

        public static NoThreadSafe GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new NoThreadSafe();
                return instance;
            }
        }

        private NoThreadSafe()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}




