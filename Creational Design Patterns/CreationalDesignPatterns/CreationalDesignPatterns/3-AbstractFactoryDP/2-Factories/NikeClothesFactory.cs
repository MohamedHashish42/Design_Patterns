using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class NikeClothesFactory : IClothesFactory
    {
        public IShirt CreateShirt()
        {
            return new NikeShirt();
        }

        public ITrousers CreateTrousers()
        {
            return new NikeTrousers();
        }
    }
}
