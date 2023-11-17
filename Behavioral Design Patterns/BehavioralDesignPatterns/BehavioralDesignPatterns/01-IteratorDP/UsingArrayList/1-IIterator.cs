namespace BehavioralDesignPatterns.IteratorDP.UsingArrayList
{
    interface IIterator
    {
        Student First();
        Student Next();
        bool HasNext();
    }
}
