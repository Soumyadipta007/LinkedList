using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add1(56);
            list.Add1(30);
            list.Add1(70);
            list.Display();
            list = new LinkedList();
            list.Add2(70);
            list.Add2(30);
            list.Add2(56);
            list.Display();
            list = new LinkedList();
            list.Add1(56);
            list.Add1(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();
            Console.WriteLine("First element popped out of the Linked List- " + list.RemoveFirstNode().data);
            list.Display();
            list.InsertAtParticularPosition(1, 56);
            list.Display();
            Console.WriteLine("Last element popped out of the Linked List- " + list.RemoveLastNode().data);
            list.Display();
        }
    }
}
