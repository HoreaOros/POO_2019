using System;
using System.Runtime.Serialization;

namespace ContBancar
{
    [Serializable]
    internal class NotEnoughFundsException : Exception
    {
        private decimal v;

        public NotEnoughFundsException()
        {
        }

        public NotEnoughFundsException(decimal v)
        {
            this.v = v;
        }

        public NotEnoughFundsException(string message) : base(message)
        {
        }

        public NotEnoughFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotEnoughFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}