﻿using System.Collections.Generic;
using System.Globalization;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7});
            
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            Console.WriteLine("Remove");

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}

