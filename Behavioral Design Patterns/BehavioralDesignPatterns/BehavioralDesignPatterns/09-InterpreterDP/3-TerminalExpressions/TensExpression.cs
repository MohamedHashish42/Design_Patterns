using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.InterpreterDP
{
    class TensExpression : Expression

    {
        private Dictionary<char, string> Tens = new Dictionary<char, string>();
        public TensExpression()
        {
            Tens.Add('0', "");
            Tens.Add('2', " Twenty");
            Tens.Add('3', " Thirty");
            Tens.Add('4', " Forty");
            Tens.Add('5', " Fifty");
            Tens.Add('6', " Sixty");
            Tens.Add('7', " Seventy");
            Tens.Add('8', " Eighty");
            Tens.Add('9', " Ninety");
        }

        public override void Interpret(Context context)
        {
            var input = context.Input;
            if (input.Length >= 2)
            {
                var digitWeNeed = input[input.Length - 2];
                context.Output += Tens[digitWeNeed];
            }
        }
    }
}
