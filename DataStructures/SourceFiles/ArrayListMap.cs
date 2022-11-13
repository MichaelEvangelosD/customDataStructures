using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class ArrayListMap<TKey, TValue> : IMap<TKey, TValue>
    {
        private IList<Tuple> entries = new ArrayList<Tuple>();

        int count = 0;

        private struct Tuple
        {
            public TKey key;
            public TValue value;
        }

        public bool Contains(TKey key)
        {
            for (int i = 0; i != entries.Count(); i++)
            {
                if (entries.Get(i).key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public int Count()
        {
            return count;
        }

        public TValue Get(TKey key)
        {
            for (int i = 0; i != entries.Count(); i++)
            {
                Tuple tempPair = entries.Get(i);

                if (tempPair.key.Equals(key))
                    return tempPair.value;
            }

            throw new KeyNotFoundException();
        }

        public TKey[] GetKeys()
        {
            TKey[] tempArray = new TKey[entries.Count()];

            for (int i = 0; i != tempArray.Length; i++)
            {
                tempArray[i] = entries.Get(i).key;
            }

            return tempArray;
        }

        public TKey[] GetKeys(TValue value)
        {
            TKey[] tempArray = new TKey[GetKeys().Length];

            for (int i = 0; i != tempArray.Length; i++)
            {
                if (entries.Get(i).value.Equals(value))
                {
                    tempArray[i] = entries.Get(i).key;
                }
            }

            return tempArray;
        }

        public void Set(TKey key, TValue value)
        {
            Tuple newPair;

            for (int i = 0; i != entries.Count(); i++)
            {
                newPair = entries.Get(i);
                if (newPair.key.Equals(key))
                {
                    newPair.value = value;
                    return;
                }
            }

            newPair = new Tuple();
            newPair.key = key;
            newPair.value = value;
            entries.Add(newPair);

            count++;
        }

        /// <summary>
        /// Removes the first occurence of key in the array.
        /// </summary>
        /// <param name="key">Key to remove</param>
        public void UnSet(TKey key)
        {
            if (Contains(key))
            {
                for (int i = 0; i != entries.Count(); i++)
                {
                    if (entries.Get(i).key.Equals(key))
                    {
                        entries.Remove(i);
                        count--;
                        break;
                    }
                }
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public override string ToString()
        {
            return ToString(" -> ", Environment.NewLine);
        }

        public string ToString(string sep, string delim)
        {
            StringBuilder s = new StringBuilder();

            for (int i = 0; i != entries.Count(); i++)
            {
                Tuple t = entries.Get(i);
                s.Append(t.key.ToString())
                    .Append(sep)
                    .Append(t.value)
                    .Append(delim);
            }

            return s.ToString();
        }
    }
}
