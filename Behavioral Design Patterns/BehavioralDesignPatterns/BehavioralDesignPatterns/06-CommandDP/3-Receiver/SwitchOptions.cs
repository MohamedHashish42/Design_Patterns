using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CommandDP
{
    public class SwitchOptions
    {
        public void On()
        {
            Console.WriteLine("The light is on");
        }

        public void Off()
        {
            Console.WriteLine("The light is off");
        }
    }
}

