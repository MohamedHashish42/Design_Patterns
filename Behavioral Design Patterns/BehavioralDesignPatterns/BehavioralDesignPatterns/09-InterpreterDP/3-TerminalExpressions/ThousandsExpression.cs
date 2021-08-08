using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.InterpreterDP
{
    class ThousandsExpression : Expression
    {
        private Dictionary<char, string>  Thousands= new Dictionary<char, string>();
        public ThousandsExpression()
        {

            Thousands.Add('0', "");
            Thousands.Add('1', " One Thousand");
            Thousands.Add('2', " Two Thousand");
            Thousands.Add('3', " Three Thousand");
            Thousands.Add('4', " Four Thousand");
            Thousands.Add('5', " Five Thousand");
            Thousands.Add('6', " Six Thousand");
            Thousands.Add('7', " Seven Thousand");
            Thousands.Add('8', " Eight Thousand");
            Thousands.Add('9', " Nine Thousand");
        }
        public override void Interpret(Context context)
        {
            var input = context.Input;
            if (input.Length >= 4)
            {
                var digitWeNeed = input[input.Length - 4];
                context.Output += Thousands[digitWeNeed];
            }
        }
    }
}
