using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.DecoratorDP
{
    class BMW : ICar
    {
        public string  Description { get; set; }
        public double Cost { get; set; }

        public BMW()
        {
           Description = "BMW";
           Cost = 5000;
        }

        public double GetCost()
        {
            return Cost;
        }

        public string GetDescription()
        {
            return Description;
        }

        public override string ToString()
        {
            return "Description : " + GetDescription() + "\nCost :" + GetCost();
        }
    }
}
