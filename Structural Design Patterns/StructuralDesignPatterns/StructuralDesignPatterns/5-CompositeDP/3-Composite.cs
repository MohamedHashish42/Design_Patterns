using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralDesignPatterns.CompositeDP
{
    public class Composite : IComponent
    {
        public string Name { get; }
        public List<IComponent> Components;
        public Composite(string name)
        {
            Name = name;
            Components = new List<IComponent>();
        }
        public void AddComponent(IComponent component)
        {
            Components.Add(component);
        }
        public string GetName()
        {
            return Name;
        }
        public int GetPrice()
        {
            return Components.Sum(c => c.GetPrice());
        }

        public void GetDetails()
        {
            Console.WriteLine("Name: " + GetName() + "\nPrice: " + GetPrice() + "\n");
            Components.ForEach((component) =>
             {
                 component.GetDetails();
             });
        }
    }
}
