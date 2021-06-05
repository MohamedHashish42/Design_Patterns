using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.CompositeDP
{
    public interface IComponent
    {
        string GetName();
        int GetPrice();
        public void GetDetails();
    }
}
