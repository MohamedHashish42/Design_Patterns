
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralDesignPatterns.ProxyDP
{

    class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;

            loadFromDisk(fileName);
        }
        private void loadFromDisk(String fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
        public void display()
        {
            Console.WriteLine("Beginning Of display Method");
            Console.WriteLine("Displaying " + fileName);
        }
    }
}
