using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public class TwoHundredHandler : Handler
    {
        public override void Handle(long requestedAmount)
        {
            long NumberOfBanknotesToTakeOfThisHandler = requestedAmount / 200;
            if (NumberOfBanknotesToTakeOfThisHandler > 0)
            {

                Console.WriteLine
                 ("Number Of Banknotes Taken By TwoHundredHandler : " + NumberOfBanknotesToTakeOfThisHandler);


            }
            long pendingAmountToBeProcessed = requestedAmount % 200;
            if (pendingAmountToBeProcessed > 0)
            {
                nextHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
