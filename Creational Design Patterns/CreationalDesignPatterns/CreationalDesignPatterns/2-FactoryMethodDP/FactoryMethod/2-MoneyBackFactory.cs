
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethodDP
{
    class MoneyBackFactory : ICreditCardFactory
    {
        public ICreditCard MakeInstance()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }

    }
}
