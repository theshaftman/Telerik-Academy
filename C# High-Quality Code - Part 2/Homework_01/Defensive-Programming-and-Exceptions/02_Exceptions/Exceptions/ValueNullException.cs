namespace _02_Exceptions.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class ValueNullException : Exception
    {
        public ValueNullException()
        {
        }

        public ValueNullException(string message) : base(message)
        {
        }

        public ValueNullException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        protected ValueNullException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}
