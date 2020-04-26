using System;
using System.Collections.Generic;
using System.Text;

namespace Cap11Exceções.Entidades.Exceção
{
    class DomainException : Exception
    {
        public DomainException(string msg) : base(msg)
        {
        }

        public DomainException(string msg, Exception inner) : base(msg, inner)
        { 
        }


    }
}
