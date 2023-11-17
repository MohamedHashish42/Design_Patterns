using System.Collections;


namespace BehavioralDesignPatterns.IteratorDP.UsingArrayList
{
    class ConcreteAggregate : IAggregate
    {
        private ArrayList _StudentsList = new ArrayList();

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
          
            return  _StudentsList[IndexPosition] as Student;
        }

       
    }
}
