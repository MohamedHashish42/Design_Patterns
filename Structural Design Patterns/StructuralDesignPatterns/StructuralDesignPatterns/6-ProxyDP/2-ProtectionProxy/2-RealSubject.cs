using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.ProxyDP
{
    class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
          Console.WriteLine
          ("Performing Read Write operation on the Shared Folder");
        }
    }
}
