using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethodDP
{
    class ClientUseFactoryDPWithFactoryMethod
    {
        public static void UsingFactoryDP(ICreditCardFactory creditCard)
        {
            ICreditCard cardDetails = CreditCardFactory.GetCardInstance(creditCard);
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
    }
}
