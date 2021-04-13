using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethodDP
{
    class CreditCardFactory
    {
        public static ICreditCard GetCardInstance(ICreditCardFactory creditCard)
        {
            return creditCard.MakeInstance();
        }
    }
}




