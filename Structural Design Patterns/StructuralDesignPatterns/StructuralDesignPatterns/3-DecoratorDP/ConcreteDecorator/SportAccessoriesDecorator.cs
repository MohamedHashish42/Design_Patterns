using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.DecoratorDP
{
    class SportAccessoriesDecorator :CarAccessoriesDecorator
    {
        public SportAccessoriesDecorator (ICar car) :base(car)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with sport accessories";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1000;
        }

  
    }
}
