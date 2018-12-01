using System;

namespace hw3
{
    /// <summary>
    /// An Checking function to make sure exception errors are taking care of. User can defind the message that get returned.
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
