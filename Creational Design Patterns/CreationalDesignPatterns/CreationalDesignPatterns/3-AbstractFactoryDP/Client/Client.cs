using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class Client
    {
        private readonly IShirt _shirt;
        private readonly ITrousers _trousers;

        public Client(IClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }

    }
}



