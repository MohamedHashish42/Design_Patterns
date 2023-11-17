
using System.Collections.Generic;
namespace BehavioralDesignPatterns.IteratorDP
{
    class ConcreteAggregate : IAggregate
    {
        private List<Student> _StudentsList = new List<Student>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return _StudentsList.Count; }
        }

        public void AddElement(Student student)
        {

            _StudentsList.Add(student);
        }

        public Student GetElement(int IndexPosition)
        {
            return _StudentsList[IndexPosition];
        }
    }
}
