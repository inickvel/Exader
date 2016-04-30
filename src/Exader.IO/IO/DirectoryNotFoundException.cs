using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exader.IO
{
    public class DirectoryNotFoundException : Exception
    {
        public DirectoryNotFoundException(string message) : base(message) { }
    }

    public class FilePathFormatException : Exception
    {
        public FilePathFormatException() { }
        public FilePathFormatException(string message) : base(message) { }
    }
}
