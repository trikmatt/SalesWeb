using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string massege) : base (massege)
        {
        }
    }
}
