using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public class HundredHandler : Handler
    {
        public override void Handle(long requestedAmount)
        {
            long NumberOfBanknotesToTakeOfThisHandler = requestedAmount / 100;
            if (NumberOfBanknotesToTakeOfThisHandler > 0)
            {

                Console.WriteLine
               ("Number Of Banknotes Taken By HundredHandler : " + NumberOfBanknotesToTakeOfThisHandler);

            }
            long pendingAmountToBeProcessed = requestedAmount % 100;
            if (pendingAmountToBeProcessed > 0)
            {
                nextHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
