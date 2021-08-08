using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public class FiveHundredHandler : Handler
    {
        public override void Handle(long requestedAmount)
        {
            long NumberOfBanknotesToTakeOfThisHandler = requestedAmount / 500;
            if (NumberOfBanknotesToTakeOfThisHandler > 0)
            {

                Console.WriteLine
                ("Number Of Banknotes Taken By FiveHundredHandler : " + NumberOfBanknotesToTakeOfThisHandler);

            }
            long pendingAmountToBeProcessed = requestedAmount % 500;
            if (pendingAmountToBeProcessed > 0)
            {
                nextHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
