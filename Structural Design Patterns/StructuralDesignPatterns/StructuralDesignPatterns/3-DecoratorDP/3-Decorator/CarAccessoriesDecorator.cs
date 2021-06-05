using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.DecoratorDP
{
    abstract class CarAccessoriesDecorator : ICar
    {
        private ICar _car;
        public CarAccessoriesDecorator(ICar car)
        {
            _car = car;
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public override string ToString()
        {
            return "Description : " + GetDescription() + "\nCost :" + GetCost();
        }
    }
}
