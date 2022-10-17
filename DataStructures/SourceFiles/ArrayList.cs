using System;

namespace DataStructures
{
    public class ArrayList<T> : IList<T>
    {
        private T[] backingArray;
        int count = 0;
        int capacityIncrement = 100;

        public int Length
        {
            get
            {
                return backingArray.Length;
            }
        }

        #region CONSTRUCTORS
        public ArrayList()
        {
            InitBackingArray(50);
        }

        public ArrayList(int size)
        {
            InitBackingArray(size);
        }
        #endregion

        #region SETUP
        void InitBackingArray(int size)
        {
            backingArray = new T[size];

            count = 0;
        }

        void ResizeBackingArrayIfNedeed()
        {
            if (count == backingArray.Length)
            {

                T[] tempArray = new T[backingArray.Length + capacityIncrement];

                backingArray.CopyTo(tempArray, 0);

                backingArray = tempArray;
            }
        }
        #endregion

        #region SERVICES
        public void Add(T element)
        {
            ResizeBackingArrayIfNedeed();

            backingArray[count] = element;
            count++;
        }

        public void Clear()
        {
            backingArray = new T[backingArray.Length];

            count = 0;
        }

        public bool Contains(T element)
        {
            if (Find(element) != -1)
            {
                return true;
            }

            return false;
        }

        public int Find(T element)
        {
            for (int i = 0; i <= count - 1; i++)
            {
                if (backingArray[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public T Get(int index)
        {
            if (index > backingArray.Length || index < 0)
            {
                throw new ArgumentException();
            }

            return backingArray[index];
        }

        public void Remove(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentException();
            }

            for (int i = index; i <= count - 2; i++)
            {
                backingArray[i] = backingArray[i + 1];
            }

            count--;
        }

        public void Insert(T element, int index)
        {
            if (index < 0 && index > count)
            {
                throw new ArgumentException();
            }

            ResizeBackingArrayIfNedeed();

            for (int i = count - 1; i >= index; i--)
            {
                backingArray[i + 1] = backingArray[i];
            }

            backingArray[index] = element;

            count++;
        }

        public int Count() => count;
        #endregion

        #region INTERNAL_OVERLOADS
        public T this[int i]
        {
            get
            {
                return (T)backingArray[i];
            }
        }

        public string ToString(string delimeter = ",")
        {

            string s = "[";

            if (count > 0)
            {
                s += backingArray[0];
                if (count > 1)
                {
                    for (int i = 1; i <= count - 1; i++)
                    {
                        s += delimeter + backingArray[i];
                    }
                }
            }

            s += "]";

            return s;
        }
        #endregion
    }
}
