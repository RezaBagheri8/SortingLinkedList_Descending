using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLinkedList_Ascending
{
    public class LinkedList
    {
        public Node head;

        public void Insert(int value)
        {
            if (IsEmpty())
            {
                Node newItem = new Node();
                newItem.value = value;

                head = newItem;
            }
            else
            {
                Node newItem = new Node();
                newItem.value = value;

                Node node = head;
                while (node.next != null)
                {
                    node = node.next;
                }

                node.next = newItem;
            }
        }

        public void SortByDescending()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Node node = head;
                for (Node i = node; i != null; i = i.next)
                {
                    Node maxNode = i;
                    for (Node j = i.next; j != null; j = j.next)
                    {
                        if (maxNode.value < j.value)
                        {
                            maxNode = j;
                        }
                    }

                    int temp = i.value;
                    i.value = maxNode.value;
                    maxNode.value = temp;
                }
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.value);
                    node = node.next;
                }
            }
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
