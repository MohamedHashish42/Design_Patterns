using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryDP
{
    class ClientApplyFactoryDB
    {
        public static void UsingFactoryDP()
        {

            ICreditCard cardDetails = CreditCardFactory.GetCardInstance("Platinum");

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
