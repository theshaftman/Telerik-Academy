namespace _02_Exceptions.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class ValueLessThanZeroException : Exception
    {
        public ValueLessThanZeroException()
        {
        }

        public ValueLessThanZeroException(string message)
            : base(message)
        {
        }

        public ValueLessThanZeroException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ValueLessThanZeroException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
