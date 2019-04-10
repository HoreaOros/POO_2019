using System;
using System.Runtime.Serialization;

namespace ContBancar
{
    [Serializable]
    internal class InvalidAmountException : Exception
    {
        private decimal v;
        public decimal Amount
        {
            get
            {
                return v;
            }
        }
        public InvalidAmountException()
        {
        }

        public InvalidAmountException(decimal v)
        {
            this.v = v;
        }

        public InvalidAmountException(string message) : base(message)
        {
        }

        public InvalidAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}