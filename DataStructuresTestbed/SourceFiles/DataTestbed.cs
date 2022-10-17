namespace DataStructuresTestbed
{
    public class DataTestbed
    {
        static void Main(string[] args)
        {
            new DataTestbed().ExecArrayListTests();
        }

        void ExecArrayListTests()
        {
            ArrayListTester arrayListTester = new ArrayListTester();
            arrayListTester.RunDataStructureTest();
        }

        void ExecLinkedListTests()
        {

        }
    }
}