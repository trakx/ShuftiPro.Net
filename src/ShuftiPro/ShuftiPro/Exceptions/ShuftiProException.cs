using System;

namespace ShuftiPro.Exceptions
{
    public class ShuftiProException : Exception
    {
        public ShuftiProException(string message) : base(message)
        {
        }
    }
}
