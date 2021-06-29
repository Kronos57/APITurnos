using System;

namespace Transversal.Exceptions
{
    public class TurnException : Exception
    {
        public TurnException(): base()
        {

        }

        public TurnException(string message) : base(message)
        {

        }
    }
}
