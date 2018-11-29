using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace hw3
{
    class Program
    {
     /// <summary>    
     /// Print the binary representation of all numbers from 1 up to n.
     /// This is accomplished by using a FIFO queue to perform a level
     ///order(i.e.BFS) traversal of a virtual binary tree that
     /// looks like this:
     ///                 1
     ///             /       \
     ///            10       11
     ///           /  \     /  \
     ///*        100  101  110  111
     ///          etc.
     /// and then storing each "value" in a list as it is "visited".
     /// </summary>

    static LinkedList<string> generateBinaryRepresentationList(int n)
        {

            //create an empty queue of strings with which to perform the traversal
            LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

            //A list for returning the binary values
            LinkedList<string> output = new LinkedList<string>();

            if (n < 1)
            {
                //binary representation of negative values is not supported
                //return an empty list
                return output;
            }

            //Enqueue the first binary number. Use a dynamic string to avoid string concat
            q.Push(new StringBuilder("1"));

            //BFS
            while (n-- > 0)
            {
                //print the front of the queue
                StringBuilder sb = q.Pop();
                output.AddLast(sb.ToString());

                //make a copy
                StringBuilder sbc = new StringBuilder(sb.ToString());

                //left child
                sb.Append('0');
                q.Push(sb);

                //right child
                sbc.Append('1');
                q.Push(sbc);
            }
            return output;
        }

        //driver program to test above function

        public static void Main(string[] args)
        {
            int n = 10;
            if (args.Length < 1)
            {
                Console.Out.WriteLine("Please invoke with the max value to print binary up to, like this: ");
                Console.Out.WriteLine("\thw3.exe 12");
                return;
            }
            try
            {
                n = Int32.Parse(args[0]);
            }
            catch (FormatException e)
            {
                Console.Out.WriteLine("I'm sorry, I can't understand the number: " + args[0]);
                return;
            }
            LinkedList<string> output = generateBinaryRepresentationList(n);

            //print it right justified. Longest string is the last one.
            //print enough spaces to move it over the correct distance

            //get lastn ode value lenght
            int maxLength = output.Last.Value.Length;

            foreach (string s in output)
            {
                for (int i = 0; i < maxLength - s.Length; ++i)
                {
                    Console.Out.Write(" ");
                }
                Console.Out.WriteLine(s);
            }
        }
    }
}
