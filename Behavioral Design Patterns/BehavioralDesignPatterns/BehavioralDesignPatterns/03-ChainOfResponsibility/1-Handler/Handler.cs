using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler nextHandler;
        public void NextHandler(Handler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
        public abstract void Handle(long requestedAmount);
    }
}
