using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.TemplateMethodDP
{
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
           Console.WriteLine
           ("Building foundation with cement, iron rods, " 
            + "wood and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine
            ("Building wood Pillars with wood coating");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Wood Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Wood Windows");
        }
    }
}
