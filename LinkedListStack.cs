using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class LinkedListStack
    {
        private Node head;
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.head == null)
                node.next = null;
            else
                node.next = this.head;
                this.head = node;
                Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
