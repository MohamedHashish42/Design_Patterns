namespace BehavioralDesignPatterns.IteratorDP
{
    interface IIterator
    {
        Student First();
        Student Next();
        bool HasNext();
    }
}
