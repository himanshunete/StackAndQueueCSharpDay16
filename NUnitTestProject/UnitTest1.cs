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
            myStack.push(myFirstNode);
            myStack.push(mySecondNode);
            myStack.push(myThirdNode);
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
            myStack.push(myFirstNode);
            myStack.push(mySecondNode);
            myStack.push(myThirdNode);
            MyNode pop = myStack.Pop();
            MyNode pop1 = myStack.Pop();
            MyNode pop2 = myStack.Pop();
            Assert.AreEqual(null, pop2.getNext());
        }
    }
}