using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    interface IAggregate
    {
        Iterator CreateIterator();
    }
}
