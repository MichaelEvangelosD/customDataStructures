using System;
using DataStructures;

namespace DataStructuresTestbed
{
    public class HashMapTester
    {
        static HashMap<string, int> hashMap;

        public void RunDataStructureTest()
        {
            hashMap = new HashMap<string, int>();

            SetTest();
        }

        void SetTest()
        {
            hashMap.Set("Alex", 15);
            hashMap.Set("Alex", 3);
            hashMap.Set("Babis", 2);
            hashMap.Set("Kostas", 1);
            hashMap.Set("George", 6);
            hashMap.Set("Nikos", 7);
        }
    }
}
