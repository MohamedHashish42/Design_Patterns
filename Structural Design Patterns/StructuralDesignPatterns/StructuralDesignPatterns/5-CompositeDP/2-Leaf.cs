using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.CompositeDP
{
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Leaf(string name, int price)
        {
            Price = price;
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetPrice()
        {
            return Price;
        }
        public void GetDetails()
        {
          Console.WriteLine("Name: " + Name + "\nPrice: " + Price + "\n");
        }

    }
}
