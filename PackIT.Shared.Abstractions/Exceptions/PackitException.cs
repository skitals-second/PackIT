using System;

namespace PackIT.Shared.Abstractions.Exceptions
{
    public abstract class PackitException : Exception
    {
        protected PackitException(string message) : base(message)
        {
        }
    }
}