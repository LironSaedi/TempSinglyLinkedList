using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    class Program
    {
        class Node<T>
        {
            public T Value;
            public Node<T> Next;

            public Node(T value) { this.Value = value; }
            public Node(T value, Node<T> next) { this.Value = value; }
        }

        class LinkedList<T>
        {
            public Node<T> Head;
            public Node<T> Tail;
            public int Count { get; private set; }

            public void AddFirst(T Value)
            {
                if (Head == null)
                {
                    Node<T> node = new Node<T>(Value);
                    Head = node;
                    Tail = Head;


                }
                else
                {
                    Node<T> nodeToInsert = new Node<T>(Value);
                    nodeToInsert.Next = Head;
                    Head.Next = nodeToInsert;

                    Count++;
                }
            }

            public void AddLast(T Value)
            {
                if (Head == null)
                {
                    Node<T> node = new Node<T>(Value);
                    Head = node;
                    Tail.Next = Head;
                    Count++;
                }
                else
                {
                    Node<T> otherNode = new Node<T>(Value);
                    Tail.Next = otherNode;
                    Tail = Tail.Next;
                    Count++;
                }
            }

            public void AddBefore(Node<T> node, T Value)
            {


                Node<T> current = Head;
                for (int i = 0; i < Count; i++, current = current.Next)
                {
                    if (current.Next == node)
                    {
                        Node<T> otherNode = new Node<T>(Value);
                        otherNode.Next = current;
                        node.Next = otherNode;
                    }
                }

            }

            public void AddAfter(Node<T> node, T Value)
            {
                Node<T> current = Head;
                for (int i = 0; i < Count; i++, current = current.Next)
                {
                    if (current == node)
                    {
                        Node<T> otherNode = new Node<T>(Value);
                        otherNode.Next = current;
                        current.Next = otherNode;
                    }
                }
            }

            public bool RemoveFirst()
            {
                if (Head == null)
                {
                    return false;
                }
                else
                {
                    Head = Head.Next;
                    Count--;
                    return true;

                }
            }

            public bool RemoveLast()
            {
                if (Head == null)
                {
                    return false;
                }
                else
                {
                    Node<T> current = Head;

                    for (int i = 0; i < Count; current = current.Next, i++)
                    {
                        if (current.Equals(Tail))
                        {
                            current.Next = null;

                            return true;
                        }
                    }

                    return false;
                }
            }

            public void Remove(T Value)
            {
                
                Node<T> current = Head;

                for (int i = 0; i < Count; current = current.Next, i++)
                {
                    if (current.Equals(Value))
                    {
                        Node<T> sample = new Node<T>();
                        current.Next = current.Next.Next;
                    }
                }

            }
        }
        static void Main(string[] args)
        {


            int input = 12;
            LinkedList<int> list = new LinkedList<int>();


            list.AddFirst(12);
            ;

            list.AddLast(input);

            Node<int> testNode = new Node<int>(7);
            list.AddBefore(testNode, input);

        }


    }
}