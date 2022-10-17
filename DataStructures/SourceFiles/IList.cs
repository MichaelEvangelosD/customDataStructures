namespace DataStructures
{
    public interface IList<T>
    {
        void Add(T element);

        void Insert(T element, int index);

        void Remove(int index);

        int Find(T element);

        T Get(int index);

        bool Contains(T element);

        void Clear();

        int Count();
    }
}
