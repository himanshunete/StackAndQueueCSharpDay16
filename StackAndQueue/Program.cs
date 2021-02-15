using System;

namespace StackAndQueue
{
    class Program
    { 
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Stack");
            MyNode myFirstNode = new MyNode(70);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(56);
            MyStack myStack = new MyStack();
            myStack.Push(myFirstNode);
            myStack.Push(mySecondNode);
            myStack.Push(myThirdNode);
            myStack.PrintStack();
            MyNode pop = myStack.Pop();
            // First Element is removed
            myStack.PrintMyNodes();
            MyNode pop1 = myStack.Pop();
            // Second Element is removed
            myStack.PrintMyNodes();
            MyNode pop2 = myStack.Pop();
            if ( pop2.getNext() == null )
            {
                Console.WriteLine("Stack is empty");
            }         
        }
    }
}
