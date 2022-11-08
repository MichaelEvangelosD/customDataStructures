namespace DataStructuresTestbed
{
    public class DataTestbed
    {
        static void Main(string[] args)
        {
            //new DataTestbed().ExecArrayListTests();
            //new DataTestbed().ExecLinkedListTests();
            //new DataTestbed().ExecMapTests();
            new DataTestbed().ExecHashMapTests();
        }

        void ExecArrayListTests()
        {
            ArrayListTester arrayListTester = new ArrayListTester();
            arrayListTester.RunDataStructureTest();
            arrayListTester.RunDataStructureStatistics();
        }

        void ExecLinkedListTests()
        {
            LinkedListTester linkedListTester = new LinkedListTester();
            linkedListTester.RunDataStructureTest();
            linkedListTester.RunDataStructuresStatistics();
        }

        void ExecMapTests()
        {
            ArrayListMapTester linkedListTester = new ArrayListMapTester();
            linkedListTester.RunDataStructureTest();
            //linkedListTester.RunDataStructuresStatistics();
        }

        void ExecHashMapTests()
        {
            HashMapTester linkedListTester = new HashMapTester();
            linkedListTester.RunDataStructureTest();
            //linkedListTester.RunDataStructuresStatistics();
        }
    }
}