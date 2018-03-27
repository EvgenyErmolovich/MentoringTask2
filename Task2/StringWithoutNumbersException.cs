using System;
using System.Runtime.Serialization;

namespace Task2
{
    [Serializable]
    class StringWithoutNumbersException : Exception
    {
        public double Cash { get; private set; }
        public StringWithoutNumbersException()
        {
        }

        public StringWithoutNumbersException(double lastData) : base()
        {
            Cash = lastData;
        }

        public StringWithoutNumbersException(string message) : base(message)
        {
        }

        public StringWithoutNumbersException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StringWithoutNumbersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
