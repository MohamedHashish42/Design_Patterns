using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class NikeShirt : IShirt
    {
        public NikeShirt()
        {
            Console.WriteLine("Niki Shirt");
        }
    }
}
