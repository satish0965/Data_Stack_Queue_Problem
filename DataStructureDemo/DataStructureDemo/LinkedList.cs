﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class LinkedLists
    {
        public Node Head;
        public Node Tail;

        public LinkedLists()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(int value)
        {
            Node node = new Node(value);
            //Check wheather the list is empty then creates node as head
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                ////If node than add new node as head 
                node.next = Head;
                Head = node;
            }
            Console.WriteLine($" Added {value} at start of the linkedlist");
        }
        public void AppendNode(int value)
        {
            Node node = new Node(value);
            //Check wheather the list is empty then creates node as head
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Node temp = Head;
                ////If node than add new node as head 
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"Added {value} at start of the linkedlist");
        }
        public bool Search(int value)
        {
            //Temp variable is head now
            Node temp = Head;
            //Check until temp location will null
            while (temp != null)
            {
                //If temp node data is equal to value to be searched
                if (temp.data == value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void InsertNode(int value, int Previousvalue)
        {
            Node newNode = new Node(value);
            if (Head == null & Tail == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                //Checking until temp variable data equal to the previous value of value to be added
                while (temp.data != Previousvalue)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
            Console.WriteLine("Added at in between: " + value);
        }
        public void DeleteNodeAtFirst()
        {
            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = Head;
            //Change head to next node to delete the previous node
            Head = Head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }
        public void DeleteNodeAtLast()
        {

            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");

            }

            Node temp = Head;
            //Check until the temp next nodes's next loction is null
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            //After getting this node change its location to null
            temp.next = null;
        }
        public void Display()
        {

            Node temp = Head;
            //Check wheather list is empty or not 
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.WriteLine(" Linked List : ");
            while (temp != null)
            {
                //Check until temp will null
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write(" -> ");
                //for traversing the node
                temp = temp.next;
            }

        }
        //public void DeleteNodeWithdata(int value)
        //{
        //    if (Head == null)
        //    {
        //        Console.WriteLine("Nothing to delete");
        //    }

        //    Node prev = this.Head;

        //    Node pointsToValue = this.Head;
        //    while (pointsToValue.data != value)
        //    {

        //        if (pointsToValue == null)
        //        {
        //            break;
        //        }
        //        pointsToValue = pointsToValue.next;
        //    }
        //    //Check until we get the previous node of node to be deleted
        //    while (prev.next.data != value)
        //    {
        //        if (prev == null)
        //        {
        //            break;
        //        }
        //        prev = prev.next;
        //    }
        //    //Change location of previous node to node to be deleted location
        //    prev.next = pointsToValue.next;

        //}
    }
}
