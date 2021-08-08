using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.InterpreterDP
{
    class Context

    {
        private string _input;
        private string _output;

        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }


        public Context(string input)
        {
            _input = input;
        }



    }
}
