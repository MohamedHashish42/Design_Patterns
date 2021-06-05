using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.DecoratorDP
{
    class BasicAccessoriesDecorator : CarAccessoriesDecorator
    {
        public BasicAccessoriesDecorator(ICar aCar) : base(aCar)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with basic accessories";
        }

        public override double GetCost()
        {
            return base.GetCost() + 500;
        }

    }
}
