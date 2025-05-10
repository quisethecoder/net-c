// See https://aka.ms/new-console-template for more information
using System;
using Random;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            
             var random = new System.Random();
             const int passwordLength = 10;
             var buffer = new char[passwordLength];
             for (var i = 0; i < passwordLength; i++)
             {
                 buffer[i] = (char)('a' + random.Next(0, 26));
             }
             var password = new string(buffer);
             Console.WriteLine(password);

       
            
        }
    }
}

