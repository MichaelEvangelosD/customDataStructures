using System;
using DataStructures;

namespace DataStructuresTestbed
{
    public class LinkedListTester
    {
        static LinkedList<int> linkedList;

        public void RunDataStructureTest()
        {
            linkedList = new LinkedList<int>();

            linkedList.Add(2);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(36);
            linkedList.Add(250);
            linkedList.Add(100);
            PrintLinkedList();

            Console.WriteLine("Inserting 1050 at index 3");
            linkedList.Insert(1050, 3);
            PrintLinkedList();

            Console.WriteLine("Inserting 23 at index 1");
            linkedList.Insert(23, 1);
            PrintLinkedList();

            Console.WriteLine("Removing at index 3");
            linkedList.Remove(3);
            PrintLinkedList();

            Console.WriteLine("Index of number 1: " + linkedList.Find(1));
            Console.WriteLine("Item at index 5: " + linkedList.Get(5));
            PrintLinkedList();

            Console.WriteLine("Does number 15 exist in LL?: " + linkedList.Contains(15));
            Console.WriteLine("Does number 2 exist in LL?: " + linkedList.Contains(2));
            PrintLinkedList();
        }

        public void RunDataStructuresStatistics()
        {
            int reps;
            long then, now, elapsed;
            double elapsedMsPerCall;

            // time addition...
            Console.WriteLine("Timing addition of one element into empty list:");

            reps = 1;
            linkedList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                linkedList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            reps = 10;
            linkedList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                linkedList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            reps = 100;
            linkedList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                linkedList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            reps = 1000;
            linkedList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                linkedList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            reps = 10000;
            linkedList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                linkedList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            reps = 100000;
            linkedList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                linkedList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            reps = 1000000;
            linkedList.Clear();
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                linkedList.Add(42);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);
        }

        void PrintLinkedList()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Count: {linkedList.Count()}");

            Console.WriteLine("List contents: " + linkedList.ToString(",") + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
