using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryDP
{ 
    class CreditCardFactory 
    {
        public static ICreditCard GetCardInstance(string cardType)
        {
            ICreditCard creditCard = null;
            if (cardType == "MoneyBack")
            {
                creditCard = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                creditCard = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                creditCard = new Platinum();
            }
            return creditCard;
        }
    }
}
