using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.BridgeDP
{
    interface IWorkshop
    {
        void Assemble();
        void Produce();
    }
}
