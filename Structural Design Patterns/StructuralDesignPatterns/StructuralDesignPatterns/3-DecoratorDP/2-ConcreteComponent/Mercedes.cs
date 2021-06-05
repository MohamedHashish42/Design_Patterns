using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.DecoratorDP
{
    class Mercedes : ICar
    {
        public string Description { get; set; }
        public double Cost { get; set; }

        public Mercedes()
        {
            Description = "Mercedes";
            Cost = 6000;
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
