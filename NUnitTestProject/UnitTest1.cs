using NUnit.Framework;
using StackAndQueue;

namespace NUnitTestProject
{
    public class Tests
    {
        /// <summary>
        /// TC-1 Test a Stack
        /// </summary>
        [Test]
        public void Given3Number_WhenAddedToStack_ShouldHaveLastAddedNode()
        {
            MyNode myFirstNode = new MyNode(70);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(56);
            MyStack myStack = new MyStack();
            myStack.Push(myFirstNode);
            myStack.Push(mySecondNode);
            myStack.Push(myThirdNode);
            myStack.PrintStack();
            MyNode peak;
            peak = myStack.Peak();
            Assert.AreEqual(myThirdNode, peak);

        }

        /// <summary>
        /// TC-2 Test to check empty stack
        /// </summary>
        [Test]
        public void Given3NumberInStack_WhenPoped_ShouldReturnEmpty()
        {

            MyNode myFirstNode = new MyNode(70);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(56);
            MyStack myStack = new MyStack();
            myStack.Push(myFirstNode);
            myStack.Push(mySecondNode);
            myStack.Push(myThirdNode);
            MyNode pop = myStack.Pop();
            MyNode pop1 = myStack.Pop();
            MyNode pop2 = myStack.Pop();
            Assert.AreEqual(null, pop2.getNext());
        }

        /// <summary>
        /// TC-3 Test to check Queue
        /// </summary>
        [Test]
        public void Given3Number_WhenAddedToQueue_ShouldHaveFirstAddedNode()
        {
            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(myFirstNode);
            myQueue.Enqueue(mySecondNode);
            myQueue.Enqueue(myThirdNode);
            myQueue.PrintQueue();
            MyNode peak;
            peak = myQueue.Peak();
            Assert.AreEqual(myFirstNode, peak);

        }

        /// <summary>
        /// TC-4 Test to empty queue 
        /// </summary>
        [Test]
        public void Given3Number_WhenDequeue_ShouldReturnEmptyQueue()
        {

            MyNode myFirstNode = new MyNode(56);
            MyNode mySecondNode = new MyNode(30);
            MyNode myThirdNode = new MyNode(70);
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(myFirstNode);
            myQueue.Enqueue(mySecondNode);
            myQueue.Enqueue(myThirdNode);
            myQueue.Dequeue();
            myQueue.Dequeue();
            MyNode dequeue2 = myQueue.Dequeue();
            Assert.AreEqual(null, dequeue2.getNext());
        }
    }
}