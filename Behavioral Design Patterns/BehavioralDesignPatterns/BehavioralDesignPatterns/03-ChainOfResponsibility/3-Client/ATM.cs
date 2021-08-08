using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public class ATM
    {
        private TwoThousandHandler _twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler _fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler _twoHundredHandler = new TwoHundredHandler();
        private HundredHandler _hundredHandler = new HundredHandler();

        public ATM()
        {
            // Prepare the chain of Handlers
            _twoThousandHandler.NextHandler(_fiveHundredHandler);
            _fiveHundredHandler.NextHandler(_twoHundredHandler);
            _twoHundredHandler.NextHandler(_hundredHandler);
        }
        public void withdraw(long requestedAmount)
        {
            _twoThousandHandler.Handle(requestedAmount);
        }
    }
}
