using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Stacks_Queues
{
    public class StackQueueMethods
    {
        public void PrintAll(Queue<char> charQueue)
        {
            Console.WriteLine("QUEUE:");

            foreach (char x in charQueue)
            {
                Console.WriteLine(x);
            }
        }

        public void PrintAll(Stack<int> intStack)
        {
            Console.WriteLine("STACK:");

            foreach (int x in intStack)
            {
                Console.WriteLine(x);
            }
        }
    }
}