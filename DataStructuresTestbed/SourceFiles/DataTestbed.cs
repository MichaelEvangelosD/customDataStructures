using DataStructures;

namespace DataStructuresTestbed
{
    public class DataTestbed
    {
        static ArrayList<int> arrayList;

        static void Main(string[] args)
        {
            new DataTestbed().RunDataStructureTest();
        }

        void RunDataStructureTest()
        {
            arrayList = new ArrayList<int>();
            Console.WriteLine("Created a default sized (50) ArrayList(custom)\n");

            AdditionTest();

            ContainsTest();

            FindTest();

            GetTest();

            ClearTest();
        }

        void AdditionTest()
        {
            Console.WriteLine("Before for loop:");
            PrintArrayListInfo();

            for (int i = 0; i < 150; i++)
            {
                arrayList.Add(i);
            }

            Console.WriteLine();
            Console.WriteLine("After for loop:");
            PrintArrayListInfo();
        }

        void ContainsTest()
        {
            Console.WriteLine();
            Console.WriteLine("Contains test (Searched for 200)");
            Console.WriteLine(arrayList.Contains(200));

            Console.WriteLine();
            Console.WriteLine("Contains test (Searched for 100)");
            Console.WriteLine(arrayList.Contains(100));

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
            Console.WriteLine("Find test - searched for the 265th");
            Console.WriteLine(arrayList.Find(265));

            PrintArrayListInfo();
        }

        void GetTest()
        {
            Console.WriteLine();

            try
            {
                Console.WriteLine("Get test - asked for the -10th element");
                Console.WriteLine(arrayList.Get(-10));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside of bounds");
            }


            try
            {
                Console.WriteLine("Get test - asked for the 350th element");
                Console.WriteLine(arrayList.Get(350));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside of bounds");
            }
        }

        void ClearTest()
        {
            arrayList.Clear();
            Console.WriteLine();
            Console.WriteLine("After clear");
            PrintArrayListInfo();
        }

        void PrintArrayListInfo()
        {
            Console.WriteLine($"Length (Max size until resize): {arrayList.Length}");
            Console.WriteLine($"Count (Actual contents): {arrayList.Count}");
        }
    }
}