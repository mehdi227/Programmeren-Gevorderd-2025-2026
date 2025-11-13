using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_BL.Exceptions
{
    public class OrganisationException : Exception
    {
        public OrganisationException()
        {
        }

        public OrganisationException(string? message) : base(message)
        {
        }

        public OrganisationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
