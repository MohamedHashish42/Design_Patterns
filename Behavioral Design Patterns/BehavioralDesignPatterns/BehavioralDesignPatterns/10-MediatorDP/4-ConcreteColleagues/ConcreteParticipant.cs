using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.MediatorDP
{
    public class ConcreteParticipant : Participant
    {
        public ConcreteParticipant(Chatroom mediator, string name) : base(mediator, name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}
