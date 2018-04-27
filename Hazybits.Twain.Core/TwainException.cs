using System;

namespace Hazybits.Twain.Core
{
    [Serializable]
    public class TwainException : Exception
    {
        public TwainException()
        {
        }

        public TwainException(string message) : base(message)
        {
        }

        public TwainException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TwainException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}
