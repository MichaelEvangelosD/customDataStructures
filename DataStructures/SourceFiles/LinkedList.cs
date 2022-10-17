using System;

namespace DataStructures
{
    public class LinkedList<T> : IList<T>
    {
        Node startNode = null;

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

            //Caches
            Node currentNode = startNode;
            Node previousNode = null;
            while (currentNode != null)
            {
                //Cache last node
                previousNode = currentNode;

                //Move to next node
                currentNode = currentNode.NextNode;
            }

            Node newNode = new Node();
            newNode.Element = element;
            newNode.NextNode = null;

            //Connect the last node with the new node
            previousNode.NextNode = newNode;
        }

        public void Insert(T element, int index)
        {
            if (index < 0 || index > Count())
            {
                throw new ArgumentException();
            }

            int counter = 0;
            Node currentNode = startNode;
            while (currentNode.NextNode != null)
            {
                if (counter == index)
                {
                    //do swap here..
                    break;
                }

                //Move to next node
                currentNode = currentNode.NextNode;
                counter++;
            }
        }

        public void Remove(int index)
        {
            throw new System.NotImplementedException();
        }

        public int Find(T element)
        {
            throw new System.NotImplementedException();
        }

        public T Get(int index)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T element)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            startNode = null;
        }

        public int Count()
        {
            if (startNode == null)
            {
                return 0;
            }

            int counter = 1;
            Node currentNode = startNode;
            while (currentNode.NextNode != null)
            {
                currentNode = currentNode.NextNode;
                counter++;
            }

            return counter;
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
