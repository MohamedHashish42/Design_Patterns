using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.InterpreterDP
{
    abstract class Expression
    {
        public abstract void Interpret(Context context);
    }
}
