using System;
using System.Collections.Generic;
using System.Text;

namespace Cap11Exceções.Entidades.Exceção
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
