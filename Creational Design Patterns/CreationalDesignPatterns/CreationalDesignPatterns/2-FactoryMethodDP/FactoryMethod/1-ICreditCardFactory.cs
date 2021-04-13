using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethodDP
{
    interface ICreditCardFactory
    {
        ICreditCard MakeInstance();
    }
}
