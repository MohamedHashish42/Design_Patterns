using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    interface IIterator
    {
        object First();
        object Next();
        bool HasNext();
    }
}
