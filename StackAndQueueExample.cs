using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StackAndQueueExample
{
    internal class Program
    {
        static void Main(string[] args){
            Stack myStack = new Stack();
            Queue myQueue = new Queue();

            /*Stack*/
            Console.WriteLine("Stack Example:");
            Console.WriteLine("Pushing item 'A'");
            myStack.Push("A");
            DisplayStack(myStack);

            Console.WriteLine("Pushing item 'B'");
            myStack.Push("B");
            DisplayStack(myStack);
            
            Console.WriteLine("Pushing item 'C'");
            myStack.Push("C");
            DisplayStack(myStack);
            
            Console.WriteLine("Item at the top is: " + myStack.Peek());

            Console.WriteLine("Popping item from stack");
            myStack.Pop();
            DisplayStack(myStack);

            Console.WriteLine("Popping item from stack");
            myStack.Pop();
            DisplayStack(myStack);
            
            /*Queue*/

            Console.WriteLine("\n\n\nQueue Example:");
            Console.WriteLine("Enqueuing item 'a'");
            myQueue.Enqueue("a");
            DisplayQueue(myQueue);

            Console.WriteLine("Enqueuing item 'b','c','d'");
            myQueue.Enqueue("b");
            myQueue.Enqueue("c");
            myQueue.Enqueue("d");
            DisplayQueue(myQueue);

            Console.WriteLine("Dequeuing item");
            myQueue.Dequeue();
            DisplayQueue(myQueue);
            
            Console.WriteLine("Clearing Queue");
            myQueue.Clear();
            DisplayQueue(myQueue);
            

        }

        public static void DisplayStack(Stack stack)
        {
            foreach (string str in stack)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Stack Size="+stack.Count);
            Console.WriteLine();
        }

        public static void DisplayQueue(Queue queue)
        {
            foreach (string str in queue)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Queue Size=" + queue.Count);
            Console.WriteLine();
        }
    }
}