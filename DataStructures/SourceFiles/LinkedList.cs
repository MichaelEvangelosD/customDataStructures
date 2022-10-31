using System;

namespace DataStructures
{
    public class LinkedList<T> : IList<T>
    {
        Node startNode = null;

        int count = 0;

        private class Node
        {
            public T Element;
            public Node NextNode;
        }

        public void Add(T element)
        {
            if (startNode == null)
            {
                startNode = new Node();
                startNode.Element = element;
                startNode.NextNode = null;
                return;
            }

            Node previousNode = GetNodeAt(count);

            Node newNode = new Node();
            newNode.Element = element;
            newNode.NextNode = null;

            //Connect the last node with the new node
            previousNode.NextNode = newNode;

            count++;
        }

        public void Insert(T element, int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentException();
            }

            Node currentNode = GetNodeAt(index - 1);

            Node cachedNode = currentNode.NextNode;
            Node newNode = new Node();

            newNode.Element = element;
            newNode.NextNode = cachedNode;

            currentNode.NextNode = newNode;

            count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > Count())
            {
                throw new ArgumentException();
            }

            Node currentNode = GetNodeAt(index - 1);
            currentNode.NextNode = currentNode.NextNode.NextNode;
            count--;
        }

        public int Find(T element)
        {
            if (count == 0)
            {
                throw new ArgumentException();
            }

            int counter = 1;
            Node tempNode = startNode;
            while (tempNode != null)
            {
                if (tempNode.Element.Equals(element))
                {
                    return counter;
                }

                tempNode = tempNode.NextNode;
                counter++;
            }

            return -1;
        }

        public T Get(int index)
        {
            if (count == 0 || index > count || index < 0)
            {
                throw new ArgumentException();
            }

            Node tempNode = GetNodeAt(index);
            return tempNode.Element;
        }

        public bool Contains(T element)
        {
            if (Find(element) != -1)
            {
                return true;
            }

            return false;
        }

        public void Clear()
        {
            startNode = null;
        }

        public int Count()
        {
            return count;
        }

        Node GetNodeAt(int index)
        {
            int indexCounter = 0;
            Node currentNode = startNode;
            while (currentNode != null)
            {
                if (indexCounter.Equals(index))
                    return currentNode;

                //Move to next node
                currentNode = currentNode.NextNode;
                indexCounter++;
            }

            return null;
        }

        public string ToString(string delimeter = ",")
        {
            string s = "[";
            Node currentNode = startNode;

            if (currentNode == null)
            {
                s += "]";
                return s;
            }

            if (Count() == 1)
            {
                s += currentNode.Element.ToString() + "]";
                return s;
            }

            while (currentNode != null)
            {
                s += currentNode.Element.ToString() + delimeter;
                currentNode = currentNode.NextNode;
            }

            s += "]";

            return s;
        }
    }
}
