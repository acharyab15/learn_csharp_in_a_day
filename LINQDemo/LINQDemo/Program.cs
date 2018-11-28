using System;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var evenNumQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int i in evenNumQuery) {
                Console.WriteLine("{0} is an even number", i);
            }
        }
    }
}
