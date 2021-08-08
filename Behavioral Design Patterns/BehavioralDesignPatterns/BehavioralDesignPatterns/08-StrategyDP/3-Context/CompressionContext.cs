using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.StrategyDP
{
    public class CompressionContext
    {
        private ICompression _Compression;
        public CompressionContext() {}
        public CompressionContext(ICompression Compression)
        {
            _Compression = Compression;
        }
        public void SetStrategy(ICompression Compression)
        {
            _Compression = Compression;
        }
        public void CompressFolder(string compressedArchiveFileName)
        {
            _Compression.Compress(compressedArchiveFileName);
        }
    }
}
