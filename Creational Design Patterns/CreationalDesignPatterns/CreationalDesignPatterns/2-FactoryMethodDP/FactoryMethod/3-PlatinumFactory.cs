using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethodDP
{
    class PlatinumFactory : ICreditCardFactory
    {
        public ICreditCard MakeInstance()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
