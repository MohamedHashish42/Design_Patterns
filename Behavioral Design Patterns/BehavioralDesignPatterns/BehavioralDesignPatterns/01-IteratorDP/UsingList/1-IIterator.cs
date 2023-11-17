﻿namespace BehavioralDesignPatterns.IteratorDP.UsingList
{
    interface IIterator
    {
        Student First();
        Student Next();
        bool HasNext();
    }
}
