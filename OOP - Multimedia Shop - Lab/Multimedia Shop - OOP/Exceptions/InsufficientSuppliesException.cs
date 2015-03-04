namespace MultimediaShop.Exceptions
{
    using System;

    class InsufficientSuppliesException : Exception
    {
        public InsufficientSuppliesException()
            : base("Insufficient supplies in the store!")
        {
        }

        public InsufficientSuppliesException(string message)
            : base(message)
        {
        }

        public InsufficientSuppliesException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
