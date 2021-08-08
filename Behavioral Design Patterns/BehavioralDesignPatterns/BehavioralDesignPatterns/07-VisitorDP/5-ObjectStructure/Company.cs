using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.VisitorDP
{
    public class Company
    {
        private static List<IElement> elements = new List<IElement>();
        public void Add(IElement employee)
        {
            elements.Add(employee);
        }

        public void Remove(IElement employee)
        {
            elements.Remove(employee);
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
