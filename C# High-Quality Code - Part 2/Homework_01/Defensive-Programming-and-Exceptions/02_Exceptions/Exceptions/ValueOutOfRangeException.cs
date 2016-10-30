namespace _02_Exceptions.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class ValueOutOfRangeException : Exception
    {
        public ValueOutOfRangeException()
        {
        }

        public ValueOutOfRangeException(string message)
            : base(message)
        {
        }

        public ValueOutOfRangeException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        protected ValueOutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
