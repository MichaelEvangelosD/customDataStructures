namespace DataStructuresTestbed
{
    public class DataTestbed
    {
        static void Main(string[] args)
        {
            new DataTestbed().ExecLinkedListTests();
        }

        void ExecArrayListTests()
        {
            ArrayListTester arrayListTester = new ArrayListTester();
            arrayListTester.RunDataStructureTest();
        }

        void ExecLinkedListTests()
        {
            LinkedListTester linkedListTester = new LinkedListTester();
            linkedListTester.RunDataStructureTest();
        }
    }
}