using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.MediatorDP
{
    public abstract class Participant
    {
        protected Chatroom mediator;
        protected string name;
        public Participant(Chatroom mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
