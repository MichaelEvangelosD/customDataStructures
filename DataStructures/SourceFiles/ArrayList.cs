using System;

namespace DataStructures
{
    public class ArrayList<T> : IList<T>
    {
        private T[] backingArray;
        int count = 0;
        int capacityIncrement = 100;

        public int Count
        {
            get
            {
                return count;
            }
        }

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

        void ResizeBackingArray()
        {
            T[] tempArray = new T[backingArray.Length + capacityIncrement];
            for (int i = 0; i < backingArray.Length; i++)
            {
                tempArray[i] = backingArray[i];
            }

            backingArray = tempArray;
        }
        #endregion

        #region SERVICES
        public void Add(T element)
        {
            try
            {
                backingArray[count] = element;
                count++;
            }
            catch (IndexOutOfRangeException)
            {
                ResizeBackingArray();

                Add(element);
            }
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
            for (int i = 0; i < backingArray.Length; i++)
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
                throw new IndexOutOfRangeException();
            }
            else
            {
                return backingArray[index];
            }
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < backingArray.Length)
            {
                backingArray[index] = default(T);
                count -= 1;
            }
            else
            {
                throw new IndexOutOfRangeException("You tried to remove an element from an invalid index position");
            }
        }

        public void Insert(T element, int index)
        {
            if (index >= 0 && index < backingArray.Length)
            {
                if (Count + 1 > backingArray.Length)
                {
                    ResizeBackingArray();
                }

                T[] tempArray = new T[backingArray.Length - index];

                for (int i = index; i < tempArray.Length; i++)
                {
                    tempArray[i] = backingArray[i];
                }

                backingArray[index] = element;

                for (int i = index; i < tempArray.Length; i++)
                {
                    backingArray[i + 1] = tempArray[i];
                }

                count++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        #endregion

        #region INTERNAL_OVERLOADS
        public T this[int i]
        {
            get
            {
                return (T)backingArray[i];
            }
        }
        #endregion
    }
}
