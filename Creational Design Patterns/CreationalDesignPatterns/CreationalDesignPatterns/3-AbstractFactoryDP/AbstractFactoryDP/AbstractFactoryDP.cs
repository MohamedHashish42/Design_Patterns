using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class AbstractFactoryDP
    {
        private readonly IShirt _shirt;
        private readonly ITrousers _trousers;

        public AbstractFactoryDP(IClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }

    }
}
