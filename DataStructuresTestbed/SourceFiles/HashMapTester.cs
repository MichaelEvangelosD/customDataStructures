using System;
using DataStructures;

namespace DataStructuresTestbed
{
    public class HashMapTester
    {
        static HashMap<string, int> hashMap;

        public void RunDataStructureTest()
        {
            hashMap = new HashMap<string, int>();

            SetTest();
        }

        void SetTest()
        {
            hashMap.Set("Alex", 15);
            hashMap.Set("Alex", 3);
            hashMap.Set("Babis", 2);
            hashMap.Set("Kostas", 1);
            hashMap.Set("George", 6);
            hashMap.Set("Nikos", 7);
        }

        static HashMap<int, int> map;
        public void RunDataStructuresStatistics()
        {
            int reps;
            long then, now, elapsed;
            double elapsedMsPerCall;

            /*            map = new HashMap<int, int>(999863);

                        reps = 1000000;
                        then = DateTime.Now.Ticks;
                        for (int i = 0; i != reps; i++)
                        {
                            map.Set(i, i);
                        }
                        now = DateTime.Now.Ticks;
                        elapsed = now - then;
                        elapsedMsPerCall = elapsed / 10000.0 / reps;
                        Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

                        Console.WriteLine("MapCount: {0}", map.Count());

                        Console.WriteLine(map.InternalStats());
            */

            map = new HashMap<int, int>();

            reps = 1;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 10;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 100;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 1000;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 10000;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 100000;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 1000000;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 10000000;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 100000000;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);

            map = new HashMap<int, int>();
            reps = 1000000000;
            then = DateTime.Now.Ticks;
            for (int i = 0; i != reps; i++)
            {
                map.Set(i, i);
            }
            now = DateTime.Now.Ticks;
            elapsed = now - then;
            elapsedMsPerCall = elapsed / 10000.0 / reps;
            Console.WriteLine("{0}: {1} ms", reps, elapsedMsPerCall);
        }
    }
}
