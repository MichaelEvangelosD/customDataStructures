namespace DataStructuresTestbed
{
    public class DataTestbed
    {
        static void Main(string[] args)
        {
            //new DataTestbed().ExecArrayListTests();
            new DataTestbed().ExecLinkedListTests();
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
    }
}