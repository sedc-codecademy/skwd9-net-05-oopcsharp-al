using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling.Exceptions
{
    public class OurException : Exception
    {
        public OurException(string message) : base(message)
        {

        }
    }
}
