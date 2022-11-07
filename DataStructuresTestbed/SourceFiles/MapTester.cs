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
            Console.WriteLine("Getting key Babis " + arrayListMap.Get("Babis"));
        }
        #endregion
    }
}
