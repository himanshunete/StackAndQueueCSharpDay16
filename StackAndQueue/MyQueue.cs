using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class MyQueue
    {
		private MyLinkedList myLinkedList ;
	
	    public MyQueue()
		{
			this.myLinkedList = new MyLinkedList();
		}

		public void Enqueue(MyNode myNode)
		{
			myLinkedList.Append(myNode);
		}

		public void PrintQueue()
		{
			myLinkedList.PrintMyNodes();
		}

		public MyNode Peak()
		{
			return myLinkedList.head;

		}

		public MyNode Dequeue()
		{
			return myLinkedList.Pop();

		}
	}
}
