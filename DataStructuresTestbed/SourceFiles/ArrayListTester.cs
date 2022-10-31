using System;
using DataStructures;

namespace DataStructuresTestbed
{
    public class ArrayListTester
    {
        static ArrayList<int> arrayList;
        static int arraySize, capacityIncrement;

        public void RunDataStructureTest()
        {
            arraySize = 1000;
            capacityIncrement = 100;

            arrayList = new ArrayList<int>(arraySize, capacityIncrement);
            Console.WriteLine("Created a {0} sized ArrayList\n with {1} capacity increments", arraySize, capacityIncrement);

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
            int numsToAdd = 100;

            Console.WriteLine("Before addition:");
            PrintArrayListInfo();

            for (int i = 0; i < numsToAdd; i++)
            {
                arrayList.Add(i);
            }

            Console.WriteLine($"Added {numsToAdd} numbers to the ArrayList");

            Console.WriteLine();
            Console.WriteLine("After addition:");
            PrintArrayListInfo();
        }

        void ContainsTest()
        {
            Console.WriteLine();
            Console.WriteLine("Contains test (Searched for 200)");
            Console.WriteLine(arrayList.Contains(200));

            Console.WriteLine();
            Console.WriteLine("Contains test (Searched for 9)");
            Console.WriteLine(arrayList.Contains(9));

        }

        void FindTest()
        {
            Console.WriteLine();
            Console.WriteLine("Find test - searched for -10");
            Console.WriteLine(arrayList.Find(-10));

            Console.WriteLine();
            Console.WriteLine("Find test - searched for 65");
            Console.WriteLine(arrayList.Find(65));

            Console.WriteLine();
            Console.WriteLine("Find test - searched for 265");
            Console.WriteLine(arrayList.Find(265));

            PrintArrayListInfo();
        }

        void GetTest()
        {
            Console.WriteLine();

            Console.WriteLine("Get test - asked for the 50th element");
            Console.WriteLine(arrayList.Get(50));

            PrintArrayListInfo();
        }

        void InsertTest()
        {
            Console.WriteLine();
            Console.WriteLine("Insert test - inserting 100 at 50th element");
            arrayList.Insert(100, 50);

            PrintArrayListInfo();
        }

        void RemoveTest()
        {
            Console.WriteLine();

            Console.WriteLine($"Removed element at 50th index {arrayList[50]}");
            arrayList.Remove(50);
            Console.WriteLine($"New element at 50th index: {arrayList[50]}");

            PrintArrayListInfo();
        }

        void ClearTest()
        {
            arrayList.Clear();
            Console.WriteLine();
            Console.WriteLine("After clear");
            PrintArrayListInfo();
        }

        public void RunDataStructureStatistics()
        {
            int reps;
            long then, now, elapsed;
            double elapsedMsPerCall;

            // time addition...
            Console.WriteLine("Timing addition of one element into empty list:");

            reps = 10000;
            arrayList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                arrayList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            reps = 100000;
            arrayList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                arrayList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            reps = 1000000;
            arrayList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                arrayList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);
        }

        void PrintArrayListInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Length (Max size until resize): {arrayList.Length}");
            Console.WriteLine($"Count (Actual contents): {arrayList.Count()}");

            Console.WriteLine("List contents: " + arrayList.ToString(","));
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}
