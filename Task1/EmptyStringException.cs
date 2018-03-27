using System;
using System.Runtime.Serialization;

namespace Task1
{
    [Serializable]
    class EmptyStringException : Exception
    {
        public double Cash { get; private set; }
        public EmptyStringException()
        {
        }

        public EmptyStringException(double lastData) : base()
        {
            Cash = lastData;
        }

        public EmptyStringException(string message): base(message)
        {
        }

        public EmptyStringException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyStringException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
