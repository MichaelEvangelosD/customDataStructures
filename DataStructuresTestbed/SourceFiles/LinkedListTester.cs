using DataStructures;

namespace DataStructuresTestbed
{
    public class LinkedListTester
    {
        static DataStructures.LinkedList<int> linkedList;

        public void RunDataStructureTest()
        {
            linkedList = new DataStructures.LinkedList<int>();

            linkedList.Add(2);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(1);


            Console.WriteLine(linkedList.Find(1));
            PrintLinkedList();
        }

        void PrintLinkedList()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Count: {linkedList.Count()}");

            Console.WriteLine("List contents: " + linkedList.ToString(","));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
