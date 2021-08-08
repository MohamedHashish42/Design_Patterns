
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StrategyDP
{
    public interface ICompression
    {
        void Compress(string compressedArchiveFileName);
    }
}
