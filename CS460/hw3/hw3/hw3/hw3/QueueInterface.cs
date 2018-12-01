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
			/// <summary>
			/// Add an element to the rear of the queue
			/// </summary>
			/// <returns>the element that was enqueued</returns>
			
            T Push(T element);
			
					
			/// <summary>
			/// Remove and return the front element.
			/// Thrown if the queue is empty
			/// <returns>remove the element from the queue and return the element removed.</return>
            T Pop();
			
			
			/// <summary>
			/// Test if the queue is empty
			/// </summary>
			/// <returns>true if the queue is empty; otherwise false</returns>
            bool IsEmpty();
        }
    }
}
