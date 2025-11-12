using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provincies_BL.Exceptions
{
    public class ZipFileManagerException : Exception
    {
        public ZipFileManagerException()
        {
        }

        public ZipFileManagerException(string? message) : base(message)
        {
        }

        public ZipFileManagerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
