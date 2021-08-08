using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CommandDP
{
    public class OpenSwitchCommand : ICommand
    {
        private SwitchOptions _switchOption;

        public OpenSwitchCommand(SwitchOptions switchOption)
        {
            _switchOption = switchOption;
        }

        public void Execute()
        {
            _switchOption.Off();
        }
    }
}


