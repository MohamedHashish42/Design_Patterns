using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactoryDP
{
    class ClientUseAbstractFactoryDP
    {
        public static void UsingAbstractFactoryDP()
        {
            AbstractFactoryDP abstractFactoryDP = new AbstractFactoryDP(new NikeClothesFactory());
        }

    }
}
