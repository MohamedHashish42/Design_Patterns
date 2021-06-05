using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.BridgeDP
{
    class Car_Workshop : CarAbstraction
    {

        public Car_Workshop(IWorkshop workshop) : base(workshop)
        {
        }

        public override void ProduceNewCar()
        {
            Workshop.Produce();
        }

        public override void AssembleNewCar()
        {
            Workshop.Assemble();
        }


    }
}
