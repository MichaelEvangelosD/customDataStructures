using System;
using DataStructures;

namespace DataStructuresTestbed
{
    public class MapTester
    {
        static ArrayListMap<string, int> arrayListMap;

        public void RunDataStructureTest()
        {
            arrayListMap = new ArrayListMap<string, int>();

            SetTest();
            ContainsTest();
            CountTest();
            GetTests();
            GetAllKeys();
            GetAllKeysWithValue(5);
        }

        #region DATA_STRUCTURE_TESTS
        void SetTest()
        {
            arrayListMap.Set("Nikos", 15);
            arrayListMap.Set("Alex", 16);
            arrayListMap.Set("George", 1);
            arrayListMap.Set("Michael", 5);
            arrayListMap.Set("Michael", 5);

            Console.WriteLine(arrayListMap.ToString());
        }

        void ContainsTest()
        {
            Console.WriteLine("Searched for Nikos " + arrayListMap.Contains("Nikos"));
            Console.WriteLine("Searched for Babis " + arrayListMap.Contains("Babis"));
        }

        void CountTest()
        {
            Console.WriteLine(arrayListMap.Count());
        }

        void GetTests()
        {
            Console.WriteLine("Getting key Nikos " + arrayListMap.Get("Nikos"));

            //Throw keyNotFound
            //Console.WriteLine("Getting key Babis " + arrayListMap.Get("Babis"));
        }

        void GetAllKeys()
        {
            string[] keys = arrayListMap.GetKeys();

            foreach (string pair in keys)
            {
                Console.WriteLine("Getting all keys " + pair);
            }
        }

        void GetAllKeysWithValue(int value)
        {
            string[] keys = arrayListMap.GetKeys(value);

            foreach (string pair in keys)
            {
                if(pair!=null)
                    Console.WriteLine($"Getting all keys with value {value} " + pair);
            }
        }
        #endregion
    }
}
