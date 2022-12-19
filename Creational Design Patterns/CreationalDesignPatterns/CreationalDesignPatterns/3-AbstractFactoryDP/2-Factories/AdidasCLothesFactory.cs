using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class AdidasCLothesFactory : IClothesFactory
    {
        public IShirt CreateShirt()
        {
            return new AdidasShirt();
        }

        public ITrousers CreateTrousers()
        {
            return new AdidasTrousers();
        }
    }
}
