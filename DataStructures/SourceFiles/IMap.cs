namespace DataStructures
{
    public interface IMap<TKey, TValue>
    {
        void Set(TKey key, TValue value);

        void UnSet(TKey key);

        TValue Get(TKey key);

        bool Contains(TKey key);

        TKey[] GetKeys(TValue value);

        TKey[] GetKeys();

        int Count();
    }
}
