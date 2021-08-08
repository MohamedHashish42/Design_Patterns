using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.InterpreterDP
{
    class ElevenToNineteenExpression : Expression
    {
        private Dictionary<char, string> Hundreds = new Dictionary<char, string>();
        public ElevenToNineteenExpression()
        {
            Hundreds.Add('1', " Eleven");
            Hundreds.Add('2', " Twelve");
            Hundreds.Add('3', " Thirteen");
            Hundreds.Add('4', " Fourteen");
            Hundreds.Add('5', " Fifteen");
            Hundreds.Add('6', " Sixteen");
            Hundreds.Add('7', " SevenTeen");
            Hundreds.Add('8', " Eighteen");
            Hundreds.Add('9', " Nineteen");

        }
        public override void Interpret(Context context)
        {
            var input = context.Input;
            if (input.Length >= 2)
            {
                var digitWeNeed = input[input.Length - 1];
                context.Output += Hundreds[digitWeNeed];
            }
        }
    }
}
