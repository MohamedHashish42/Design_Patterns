namespace BehavioralDesignPatterns.IteratorDP
{
    class Iterator : IIterator
    {
        private ConcreteAggregate _collection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(ConcreteAggregate collection)
        {
            this._collection = collection;
        }

        public Student First()
        {
            _current = 0;
            return _collection.GetElement(_current);
        }

        public Student Next()
        {
            _current += _step;
            if (HasNext())
            {
                return _collection.GetElement(_current);
            }
            else
            {
                return null;
            }
        }

        public bool HasNext()
        {
            return _current < _collection.Count;
        }

    }
}
