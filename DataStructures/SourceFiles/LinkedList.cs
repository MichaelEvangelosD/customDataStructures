using System;

namespace DataStructures
{
    public class LinkedList<T> : IList<T>
    {
        private class Node
        {
            public T Element;
            public Node NextNode;
        }

        Node startNode = null;

        public void Add(T element)
        {
            Node tempNode = startNode;

            while (tempNode.NextNode != null)
            {
                tempNode = tempNode.NextNode;
            }

            tempNode.Element = element;
            tempNode.NextNode = null;
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
                    //do swap here...
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

            if (startNode != null)
            {
                while (currentNode.NextNode != null)
                {
                    s += delimeter + currentNode.Element.ToString();
                }
            }
            s += "]";

            return s;
        }
    }
}
