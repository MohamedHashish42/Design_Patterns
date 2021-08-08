using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.IteratorDP
{
    class ConcreteAggregate : IAggregate
    {
        private List<employee> _listEmployees = new List<employee>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return _listEmployees.Count; }
        }

        public void AddEmployee(employee employee)
        {
            _listEmployees.Add(employee);
        }

        public employee GetEmployee(int IndexPosition)
        {
            return _listEmployees[IndexPosition];
        }
    }
}
