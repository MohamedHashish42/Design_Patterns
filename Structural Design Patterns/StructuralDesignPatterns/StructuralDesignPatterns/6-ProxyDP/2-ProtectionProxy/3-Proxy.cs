using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.ProxyDP
{
    class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Person _person;
        public SharedFolderProxy(Person person)
        {
            _person = person;
        }
        public void PerformRWOperations()
        {
            if ( _person.Role == role.CEO || _person.Role ==role.MANAGER)
            {
                folder = new SharedFolder();
                folder.PerformRWOperations();
            }
            else
            {
               Console.WriteLine
               ("You don't have permission to access this folder");
            }
        }
    }
}
