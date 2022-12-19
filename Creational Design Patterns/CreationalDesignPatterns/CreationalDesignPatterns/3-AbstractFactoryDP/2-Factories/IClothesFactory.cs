using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    interface IClothesFactory
    {
        public IShirt CreateShirt();
        public ITrousers CreateTrousers();
    }
}
