using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class AdidasTrousers : ITrousers
    {
        public AdidasTrousers()
        {
            Console.WriteLine("Adidas Trousers");
        }
    }
}
