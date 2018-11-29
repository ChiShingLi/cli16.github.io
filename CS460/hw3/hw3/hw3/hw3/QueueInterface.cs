using System;

namespace hw3
{
    /// <summary>
    /// Queue core function calls.
    /// </summary>
    class QueueInterface
    {
        public interface IqueueInterface<T>
        {
            T Push(T element);
            T Pop();
            bool IsEmpty();
        }
    }
}
