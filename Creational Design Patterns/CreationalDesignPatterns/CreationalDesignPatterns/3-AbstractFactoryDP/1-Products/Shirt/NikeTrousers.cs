using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class NikeTrousers : ITrousers
    {
        public NikeTrousers()
        {
            Console.WriteLine("Niki Trousers");
        }
    }
}
