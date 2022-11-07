namespace DataStructuresTestbed
{
    public class DataTestbed
    {
        static void Main(string[] args)
        {
            //new DataTestbed().ExecArrayListTests();
            //new DataTestbed().ExecLinkedListTests();
            new DataTestbed().ExecMapTests();
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
            MapTester linkedListTester = new MapTester();
            linkedListTester.RunDataStructureTest();
            //linkedListTester.RunDataStructuresStatistics();
        }
    }
}