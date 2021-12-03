using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class Operations
    {
        public static void ListDemo()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(2);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }           
        }
        public static void StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
        public static void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Dequeue();
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
        }
        public static void HashSetDemo()
        {
            HashSet<int> hash = new HashSet<int>();
            hash.Add(10);
            hash.Add(11);
            hash.Add(12);
            hash.Add(10);
            foreach (var element in hash)
            {
                Console.WriteLine(element);
            }
        }
        public static void DictionaryDemo()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1,"venu");
            dict.Add(2,"gopal");
            dict.Add(3,"Reddy");
            foreach (var element in dict)
            {
                Console.WriteLine("key: "+element.Key + " & "+"value: "+element.Value);
            }
        }
    }
}
