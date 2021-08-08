using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.VisitorDP
{
    public interface IElement
    {
        public void Accept(IVisitor visitor);
    }
}
