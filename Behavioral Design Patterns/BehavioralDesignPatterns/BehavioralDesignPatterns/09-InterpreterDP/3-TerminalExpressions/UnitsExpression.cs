using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.InterpreterDP
{
    class UnitsExpression : Expression
    {
        private Dictionary<char, string> Units = new Dictionary<char, string>();
        public UnitsExpression()
        {
            Units.Add('0', "");
            Units.Add('1', " One");
            Units.Add('2', " Two");
            Units.Add('3', " Three");
            Units.Add('4', " Four");
            Units.Add('5', " Five");
            Units.Add('6', " Six");
            Units.Add('7', " Seven");
            Units.Add('8', " Eight");
            Units.Add('9', " Nine");

        }
        public override void Interpret(Context context)
        {
            var input = context.Input;
            if (input.Length >= 1)
            {
                var digitWeNeed = input[input.Length - 1];
                context.Output += Units[digitWeNeed];
            }
        }
    }
}
