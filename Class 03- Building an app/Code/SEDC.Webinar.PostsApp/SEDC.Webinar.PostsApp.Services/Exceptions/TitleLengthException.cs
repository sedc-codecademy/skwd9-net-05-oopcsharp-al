using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Webinar.PostsApp.Services.Exceptions
{
    public class TitleLengthException : Exception
    {
        public TitleLengthException(string message) : base(message)
        {

        }
    }
}
