using System;

namespace hw3
{
    /// <summary>
    /// An Checking function to make sure errors are taking care of
    /// </summary>
    class QueueUnderflowException : SystemException
    {
        public QueueUnderflowException() : base()
        { 
        }

        public QueueUnderflowException(string message) : base(message)
        {
        }
    }
}
