
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.ProxyDP
{
    public class ImageProxy : IImage
    {

        private RealImage realImage;

        private string fileName;
        public ImageProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.display();
        }
    }
}
