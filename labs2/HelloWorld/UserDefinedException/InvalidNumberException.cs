using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    internal class InvalidNumberException : ApplicationException
    {
        public InvalidNumberException()
        {
        }

        public InvalidNumberException(string? message) : base(message)
        {
        }

        public InvalidNumberException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
