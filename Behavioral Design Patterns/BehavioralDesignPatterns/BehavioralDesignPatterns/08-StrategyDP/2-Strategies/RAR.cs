using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StrategyDP
{
    public class RAR : ICompression
    {
        public void Compress(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '"
                             + compressedArchiveFileName + ".rar' file is created");
        }
    }
}
