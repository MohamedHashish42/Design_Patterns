using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ObserverDP
{
    public interface ISubject
    {
        //To attach an observer to the subject.
        void Attach(IObserver observer);

        //To detach an observer from the subject
        void Detach(IObserver observer);

        //To notify all observers about an event.
        void Notify();
    }
}
