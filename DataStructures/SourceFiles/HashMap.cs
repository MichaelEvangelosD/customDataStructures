using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class HashMap<TKey, TValue> : IMap<TKey, TValue>
    {
        List<Tuple<TKey, TValue>>[] data;

        int count = 0;

        struct Tuple<Tkey, TValue>
        {
            public TKey key;
            public TValue value;
        }

        public HashMap(int capacity = 997)
        {
            data = new List<Tuple<TKey, TValue>>[capacity];
        }

        public void Set(TKey key, TValue value)
        {
            uint hash = (uint)((uint)(key.GetHashCode()) % data.Length);

            Tuple<TKey, TValue> newPair = new Tuple<TKey, TValue>();
            newPair.key = key;
            newPair.value = value;

            if (data[hash] == null)
            {
                List<Tuple<TKey, TValue>> newBucket = new List<Tuple<TKey, TValue>>();
                newBucket.Add(newPair);

                data[hash] = newBucket;
                count++;
            }
            else
            {
                List<Tuple<TKey, TValue>> bucket = data[hash];
                bucket.Add(newPair);
                count++;
            }
        }

        public void UnSet(TKey key)
        {
            uint hash = (uint)((uint)key.GetHashCode() % data.Length);

            if (data[hash] != null)
            {
                List<Tuple<TKey, TValue>> bucketAtHash = data[hash];

                for (int i = 0; i != bucketAtHash.Count; i++)
                {
                    if (bucketAtHash[i].key.Equals(key))
                    {
                        count--;
                        bucketAtHash.RemoveAt(i);
                        return;
                    }
                }
            }

            throw new Exception();
        }

        public TValue Get(TKey key)
        {
            uint hash = (uint)((uint)(key.GetHashCode()) % data.Length);

            if (data[hash] != null)
            {
                List<Tuple<TKey, TValue>> bucket = data[hash];

                for (int i = 0; i != bucket.Count; i++)
                {
                    if (bucket[i].key.Equals(key))
                    {
                        return bucket[i].value;
                    }
                }
            }

            throw new Exception();
        }

        public TKey[] GetKeys()
        {
            List<TKey> allKeys = new List<TKey>();

            for (int i = 0; i < data.Length; i++)
            {
                // TODO
            }

            return allKeys.ToArray();
        }

        public TKey[] GetKeys(TValue value)
        {
            List<TKey> allKeys = new List<TKey>();

            for (int i = 0; i < data.Length; i++)
            {
                // TODO
            }

            return allKeys.ToArray();
        }

        public bool Contains(TKey key)
        {
            uint hash = (uint)((uint)(key.GetHashCode()) % data.Length);

            if (data[hash] != null)
            {
                List<Tuple<TKey, TValue>> hashBucket = data[hash];

                for (int i = 0; i != hashBucket.Count; i++)
                {
                    if (hashBucket[i].key.Equals(key))
                        return true;
                }
            }

            return false;
        }

        public int Count()
        {
            return count;
        }

        public string InternalStats()
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            int median;

            List<Tuple<TKey, TValue>> value;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == null) continue;

                value = data[i];

                if (value.Count < min)
                {
                    min = value.Count;
                }

                if (value.Count > max)
                {
                    max = value.Count;
                }
            }

            median = (max + min) / 2;

            return $"Min: {min} + Max {max} + Median {median}";
        }

        public override string ToString()
        {
            return ToString(" -> ", Environment.NewLine);
        }

        public string ToString(string sep, string delim)
        {
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != null)
                {
                    //TODO:
                }
            }

            return s.ToString();
        }
    }
}
