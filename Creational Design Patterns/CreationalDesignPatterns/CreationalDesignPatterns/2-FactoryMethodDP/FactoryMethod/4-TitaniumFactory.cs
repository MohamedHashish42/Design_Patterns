using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethodDP
{
    class TitaniumFactory : ICreditCardFactory
    {
        public ICreditCard MakeInstance()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}
