using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.VisitorDP
{
    public interface IVisitor
    {
        void Visit(Employee element);
    }
}
