using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.BridgeDP
{
    abstract class CarAbstraction
    {
        protected IWorkshop Workshop;

        protected CarAbstraction(IWorkshop workshop)
        {
            Workshop = workshop;
        }

        abstract public void ProduceNewCar();
        abstract public void AssembleNewCar();

    }
}
