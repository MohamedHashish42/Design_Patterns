using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public class TwoThousandHandler : Handler
    {
        public override void Handle(long requestedAmount)
        {
            long NumberOfBanknotesToTakeOfThisHandler = requestedAmount / 2000;
            if (NumberOfBanknotesToTakeOfThisHandler > 0)
            {

                Console.WriteLine
                ("Number Of Banknotes Taken By TwoThousandHandler : " + NumberOfBanknotesToTakeOfThisHandler);

            }

            long pendingAmountToBeProcessed = requestedAmount % 2000;

            if (pendingAmountToBeProcessed > 0)
            {
                nextHandler.Handle(pendingAmountToBeProcessed);
            }
        }
    }
}
