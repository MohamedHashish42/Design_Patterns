using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CommandDP
{

    public class LightRemoteControle
    {
        ICommand _command;

        public LightRemoteControle(ICommand command)
        {
            _command = command;
        }

        public void Execute()
        {
            _command.Execute();
        }

    }
}
