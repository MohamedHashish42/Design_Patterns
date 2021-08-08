using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    interface IIterator
    {
        employee First();
        employee Next();
        bool HasNext();
    }
}
