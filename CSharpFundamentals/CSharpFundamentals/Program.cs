// See https://aka.ms/new-console-template for more information


using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var addResult = calculator.Add(1, 2);
            var subtractResult = calculator.Subtract(3, 2);
            Console.WriteLine("The result is: " + addResult + " and " + subtractResult);
        }
    }
}