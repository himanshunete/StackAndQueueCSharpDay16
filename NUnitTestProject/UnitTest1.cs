using NUnit.Framework;
using StackAndQueue;

namespace NUnitTestProject
{
    public class Tests
    {
        /// <summary>
        /// UC-1 Test a Stack
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
    }
}