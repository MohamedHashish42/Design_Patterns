using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    class Iterator : IIterator
    {
        private ConcreteAggregate collection;
        private int index = 0;
        private int step = 1;

        public Iterator(ConcreteAggregate collection)
        {
            this.collection = collection;
        }

        public object First()
        {
            index = 0;
            return collection.GetElement(index);
        }

        public object Next()
        {
            index += step;
            if (HasNext())
            {
                return collection.GetElement(index);
            }
            else
            {
                return null;
            }
        }

        public bool HasNext()
        {
            return index < collection.Count;
        }

    }
}
