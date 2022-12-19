using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class AdidasShirt : IShirt
    {
        public AdidasShirt()
        {
            Console.WriteLine("Adidas Shirt");
        }
    }
}


