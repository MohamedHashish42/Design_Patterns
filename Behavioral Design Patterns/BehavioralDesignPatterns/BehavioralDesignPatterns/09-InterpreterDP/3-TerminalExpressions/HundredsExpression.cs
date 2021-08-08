using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.InterpreterDP
{
    class HundredsExpression : Expression
    {
        private Dictionary<char, string> Hundreds = new Dictionary<char, string>();
        public HundredsExpression()
        {
            Hundreds.Add('0', "");
            Hundreds.Add('1', " One Hundred");
            Hundreds.Add('2', " Two Hundred");
            Hundreds.Add('3', " Three Hundred");
            Hundreds.Add('4', " Four Hundred");
            Hundreds.Add('5', " Five Hundred");
            Hundreds.Add('6', " Six Hundred");
            Hundreds.Add('7', " Seven Hundred");
            Hundreds.Add('8', " Eight Hundred");
            Hundreds.Add('9', " Nine Hundred");

        }
        public override void Interpret(Context context)
        {
            var input = context.Input;
            if (input.Length >= 3)
            {
                var digitWeNeed = input[input.Length - 3];
                context.Output += Hundreds[digitWeNeed];
            }
        }
    }
}
