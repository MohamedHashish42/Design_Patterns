using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.BridgeDP
{
    class BMW_Workshop : IWorkshop
    {
        public void Produce()
        {
            Console.WriteLine("a New BMW car was produced ");
        }

        void IWorkshop.Assemble()
        {
            Console.WriteLine("the New BMW car was assembled");
        }
    }
}
