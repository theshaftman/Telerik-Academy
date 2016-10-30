namespace _02_Exceptions.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class ValueNullOrEmptyException : Exception
    {
        public ValueNullOrEmptyException()
        {
        }

        public ValueNullOrEmptyException(string message)
            : base(message)
        {
        }

        public ValueNullOrEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ValueNullOrEmptyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
