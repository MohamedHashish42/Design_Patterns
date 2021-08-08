using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CommandDP
{

    public class LightRemoteControle
    {
        ICommand _closedCommand;
        ICommand _openedCommand;

        public LightRemoteControle(ICommand closedCommand, ICommand openedCommand)
        {
            _closedCommand = closedCommand;
            _openedCommand = openedCommand;
        }

        public void Close()
        {
            _closedCommand.Execute();
        }

        public void Open()
        {
            _openedCommand.Execute();
        }
    }
}
