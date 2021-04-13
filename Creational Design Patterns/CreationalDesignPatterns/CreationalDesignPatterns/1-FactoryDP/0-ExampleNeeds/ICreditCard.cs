using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryDP
{
    interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
 
}
