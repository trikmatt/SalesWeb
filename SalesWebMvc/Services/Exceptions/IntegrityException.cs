using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string messege) : base(messege) 
        {
        }
    }
}
