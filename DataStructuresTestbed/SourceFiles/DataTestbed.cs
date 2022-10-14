using DataStructures;

namespace DataStructuresTestbed
{
    public class DataTestbed
    {
        static ArrayList<int>? arrayList;

        static void Main(string[] args)
        {
            new DataTestbed().RunDataStructureTest();
        }

        void RunDataStructureTest()
        {
            arrayList = new ArrayList<int>(50);
            Console.WriteLine("Created a 50 sized ArrayList(custom)\n");

            AdditionTest();

            ContainsTest();

            FindTest();

            GetTest();

            InsertTest();

            RemoveTest();

            ClearTest();
        }

        #region DATA_STRUCTURE_TESTS
        void AdditionTest()
        {
            int numsToAdd = 100000;

            Console.WriteLine("Before the for loop:");
            PrintArrayListInfo();

            for (int i = 0; i < numsToAdd; i++)
            {
                arrayList?.Add(i);
            }

            Console.WriteLine($"Added {numsToAdd} numbers to the ArrayList");

            Console.WriteLine();
            Console.WriteLine("After the for loop:");
            PrintArrayListInfo();
        }

        void ContainsTest()
        {
            Console.WriteLine();
            Console.WriteLine("Contains test (Searched for 200)");
            Console.WriteLine(arrayList?.Contains(200));

            Console.WriteLine();
            Console.WriteLine("Contains test (Searched for 100)");
            Console.WriteLine(arrayList?.Contains(100));

        }

        void FindTest()
        {
            Console.WriteLine();
            Console.WriteLine("Find test - searched for -10");
            Console.WriteLine(arrayList?.Find(-10));

            Console.WriteLine();
            Console.WriteLine("Find test - searched for 65");
            Console.WriteLine(arrayList?.Find(65));

            Console.WriteLine();
            Console.WriteLine("Find test - searched for 265");
            Console.WriteLine(arrayList?.Find(265));

            PrintArrayListInfo();
        }

        void GetTest()
        {
            Console.WriteLine();

            try
            {
                Console.WriteLine("Get test - asked for the -10th element");
                Console.WriteLine(arrayList?.Get(-10));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside of bounds");
            }

            try
            {
                Console.WriteLine("Get test - asked for the 100th element");
                Console.WriteLine(arrayList?.Get(100));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside of bounds");
            }

            try
            {
                Console.WriteLine("Get test - asked for the 350th element");
                Console.WriteLine(arrayList?.Get(350));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside of bounds");
            }

            PrintArrayListInfo();
        }

        void InsertTest()
        {
            Console.WriteLine();
            Console.WriteLine("Insert test - inserting 100 at 50th element");
            arrayList?.Insert(100, 50);

            Console.WriteLine("Insert test - inserting 2500 at 154th element");
            arrayList?.Insert(2500, 154);

            PrintArrayListInfo();
        }

        void RemoveTest()
        {
            Console.WriteLine();

            Console.WriteLine($"Removed element at 50th index {arrayList?[50]}");
            arrayList?.Remove(50);
            Console.WriteLine($"New element at 50th index: {arrayList?[50]}");

            PrintArrayListInfo();

            try
            {
                Console.WriteLine("Removed element at 1500th index - throws IndexOutOfBoundsException");
                arrayList?.Remove(1500);
                PrintArrayListInfo();
            }
            catch (IndexOutOfRangeException)
            {
                //nop...
            }

            try
            {
                Console.WriteLine("Removed element at -100th index - throws IndexOutOfBoundsException");
                arrayList?.Remove(-100);
                PrintArrayListInfo();
            }
            catch (IndexOutOfRangeException)
            {
                //nop...
            }
        }

        void ClearTest()
        {
            arrayList?.Clear();
            Console.WriteLine();
            Console.WriteLine("After clear");
            PrintArrayListInfo();
        }

        void PrintArrayListInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Length (Max size until resize): {arrayList?.Length}");
            Console.WriteLine($"Count (Actual contents): {arrayList?.Count}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}