using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StrategyDP
{
    public class ZIP : ICompression
    {
        public void Compress(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '"
                             + compressedArchiveFileName + ".zip' file is created");
        }
    }
}
