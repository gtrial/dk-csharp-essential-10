using System;
using task02;

namespace task04
{
    internal static class Program
    {
        private static T[] GetArray<T>(this MyList<T> list)
        {
            return new T[] { };
        }

        private static void Main()
        {
            var myList = new MyList<int>(new [] {1, 2});
            foreach (var row in myList.GetArray())
            {
                Console.WriteLine(row);
            }
        }
    }
}