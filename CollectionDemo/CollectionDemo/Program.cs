using System;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nList");
            Operations.ListDemo();
            Console.WriteLine("\nStack");
            Operations.StackDemo();
            Console.WriteLine("\nQueue");
            Operations.QueueDemo();
            Console.WriteLine("\nHashset");
            Operations.HashSetDemo();
            Console.WriteLine("\nDictionary");
            Operations.DictionaryDemo();
        }
    }
}
