using System;
using static LinkedLists.LinkedList;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var llist = new LinkedList();

            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            llist.head.next = second; // Link first node with the second node
            second.next = third; // Link second node with the third node

            Console.WriteLine("Hello World!");
        }
    }

    public class LinkedList
    {
        public Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
    }
}
