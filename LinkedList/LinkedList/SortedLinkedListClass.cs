using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SortedLinkedListClass
    {
        internal Node head;     
        public void Add(int data)
        {
            Node newNode = new Node(data);
            Node current;
            if (head == null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                current = head;
                while (current.next != null && current.next.data < newNode.data)
                    current = current.next;
                newNode.next = current.next;
                current.next = newNode;
            }
            Console.WriteLine("{0} inserted into the linked list", newNode.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty.");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
