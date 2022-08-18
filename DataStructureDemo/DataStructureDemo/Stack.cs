﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    public class Stack
    {
        LinkedLists linkedList;

        public Stack()
        {

            linkedList = new LinkedLists();
        }

        public void Push(int value)
        {
            //Adding new node in stack 
            linkedList.AppendNode(value);
        }

        public void DisplayStack()
        {
            Console.WriteLine("Stack:");
            linkedList.Display();
        }

        public Node Top()
        {
            //Return top value of stack
            return linkedList.Head;
        }
        public void pop()
        {
            //Delete Node from stack
            linkedList.DeleteNodeAtFirst();
        }
    }
}