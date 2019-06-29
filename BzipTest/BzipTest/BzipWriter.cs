using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace BzipTest
{
    public class BzipWriter
    {
        FileStream _fs;
        BZip2Stream _bzipStream;
        StreamWriter _writer;

        public BzipWriter(string pathname, BZip2CompressionLevel compressionLevel = BZip2CompressionLevel.Default)
        {
            _fs = new FileStream(pathname, FileMode.Append);
            _bzipStream = new BZip2Stream(_fs, compressionLevel);
            _writer = new StreamWriter(_bzipStream);
        }

        public void WriteLine(string text)
        {
            _writer.WriteLine(text);
        }

        public void Close()
        {
            _writer.Flush();
            _writer.Close();
        }

    } // END OF CLASS BzipWriter

} // END OF NAMESPACE
