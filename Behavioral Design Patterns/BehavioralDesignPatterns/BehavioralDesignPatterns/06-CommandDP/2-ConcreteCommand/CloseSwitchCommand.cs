using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CommandDP
{
    public class CloseSwitchCommand : ICommand
    {
        private SwitchOptions _switchOption;

        public CloseSwitchCommand(SwitchOptions switchOption)
        {
            _switchOption = switchOption;
        }

        public void Execute()
        {
            _switchOption.Off();
        }
    }
}
