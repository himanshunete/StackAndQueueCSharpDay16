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
            myStack.push(myFirstNode);
            myStack.push(mySecondNode);
            myStack.push(myThirdNode);
            myStack.PrintStack();
            MyNode peak;
            peak = myStack.Peak();
        }
    }
}
