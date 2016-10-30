namespace _02_Exceptions.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class UnexpectedValueException : Exception
    {
        public UnexpectedValueException()
        {
        }

        public UnexpectedValueException(string message)
            : base(message)
        {
        }

        public UnexpectedValueException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected UnexpectedValueException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
