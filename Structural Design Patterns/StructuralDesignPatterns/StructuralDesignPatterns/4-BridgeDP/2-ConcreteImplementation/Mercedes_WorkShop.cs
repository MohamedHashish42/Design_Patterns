using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.BridgeDP
{
    class Mercedes_WorkShop : IWorkshop
    {
        public void Produce()
        {
            Console.WriteLine("a New Mercedes car was produced ");
        }

        void IWorkshop.Assemble()
        {
            Console.WriteLine("the New Mercedes car was assembled");
        }
    }
}
