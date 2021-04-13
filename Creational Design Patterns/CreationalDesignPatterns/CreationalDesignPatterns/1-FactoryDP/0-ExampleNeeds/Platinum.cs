using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryDP
{
    class Platinum :ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
