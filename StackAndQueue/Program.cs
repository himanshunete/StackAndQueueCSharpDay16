using System;

namespace StackAndQueue
{
    class Program
    { 
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Queue");
            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(myFirstNode);
            myQueue.Enqueue(mySecondNode);
            myQueue.Enqueue(myThirdNode);
            myQueue.Dequeue();
            myQueue.PrintQueue();
            myQueue.Dequeue();
            myQueue.PrintQueue();
            MyNode dequeue2 = myQueue.Dequeue();
            if ( dequeue2.getNext() == null )
            {
                Console.WriteLine("Queue is empty");
            }         
        }
    }
}
