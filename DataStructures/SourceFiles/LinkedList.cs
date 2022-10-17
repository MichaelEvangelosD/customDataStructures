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
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }
}
