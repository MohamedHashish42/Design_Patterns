using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    class ConcreteAggregate : IAggregate
    {
        private List<object> _elementsList = new List<object>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return _elementsList.Count; }
        }

        public void AddElement(object employee)
        {
            _elementsList.Add(employee);
        }

        public object GetElement(int IndexPosition)
        {
            return _elementsList[IndexPosition];
        }
    }
}
