﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class MyStack
    {
		private MyLinkedList myLinkedList ;
		MyNode head;
	
	public MyStack()
		{
			this.myLinkedList = new MyLinkedList();
		}

		public void Push(MyNode myNode)
		{
			myLinkedList.Add(myNode);
		}

		public void PrintStack()
		{
			myLinkedList.PrintMyNodes();
		}

		public MyNode Peak()
		{ 
			return myLinkedList.head;
		}

		public MyNode Pop()
		{
			return myLinkedList.Pop();

		}

		public void PrintMyNodes()
        {
			myLinkedList.PrintMyNodes();
        }
	}
}
