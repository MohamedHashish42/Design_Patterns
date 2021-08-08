using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    class Iterator : IIterator
    {
        private ConcreteAggregate collection;
        private int current = 0;
        private int step = 1;

        public Iterator(ConcreteAggregate collection)
        {
            this.collection = collection;
        }

        public employee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }

        public employee Next()
        {
            current += step;
            if (HasNext())
            {
                return collection.GetEmployee(current);
            }
            else
            {
                return null;
            }
        }

        public bool HasNext()
        {
            return current < collection.Count;
        }
    }
}
