using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_BL.Exceptions
{
    public class MemberException : Exception
    {
        public MemberException()
        {
        }

        public MemberException(string? message) : base(message)
        {
        }

        public MemberException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
