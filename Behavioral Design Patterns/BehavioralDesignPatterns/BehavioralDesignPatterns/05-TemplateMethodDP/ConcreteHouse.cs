using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.TemplateMethodDP
{
    public class ConcreteHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine
            ("Building foundation with cement, iron rods " 
             +"and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine
            ("Building Concrete Pillars with Cement and Sand");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Concrete Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Concrete Windows");
        }
    }
}
