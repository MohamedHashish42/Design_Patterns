using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethodDP

{
    interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
 
}
