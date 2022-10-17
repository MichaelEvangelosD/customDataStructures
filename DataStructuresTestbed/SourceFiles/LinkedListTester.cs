﻿using DataStructures;

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
            linkedList.Add(36);
            linkedList.Add(250);
            linkedList.Add(100);
            PrintLinkedList();

            Console.WriteLine("Inserting 1050 at index 3");
            linkedList.Insert(1050, 3);
            Console.WriteLine("Inserting 23 at index 1");
            linkedList.Insert(23, 1);
            PrintLinkedList();

            Console.WriteLine("Removing at index 3");
            linkedList.Remove(3);
            PrintLinkedList();

            Console.WriteLine("Index of number 1: " + linkedList.Find(1));
            Console.WriteLine("Item at index 1: " + linkedList.Get(1));
            PrintLinkedList();

            Console.WriteLine("Does number 15 exist in LL?: " + linkedList.Contains(15));
            Console.WriteLine("Does number 2 exist in LL?: " + linkedList.Contains(2));
            PrintLinkedList();
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
