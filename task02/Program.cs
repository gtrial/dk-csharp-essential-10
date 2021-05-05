using System;

namespace task02
{
    internal static class Program
    {
        private static void Main()
        {
            var myList = new MyList<int>(new[] {1, 2, 3});
            myList.Add(4);
            Console.WriteLine((myList.Index(0)));
            Console.WriteLine((myList.Length));
        }
    }
}