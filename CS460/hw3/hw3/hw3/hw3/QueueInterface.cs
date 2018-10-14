using System;


namespace hw3
{
    class QueueInterface
    {
        public interface queueInterface<T>
        {
            T push(T element);
            T pop();
            bool isEmpty();
        }
    }
}
