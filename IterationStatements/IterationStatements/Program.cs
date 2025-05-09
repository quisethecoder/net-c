// See https://aka.ms/new-console-template for more information

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loops
            /*for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            foreach loops
            */
            // var name = "John Smith";

            // for (var i = 0; i < name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }
            
            // foreach (var character in name)
            // {
            //     Console.WriteLine(character);
            // }

            // var numbers = new int[] { 1, 2, 3, 4, 5 };
            //
            // foreach (var x in numbers)
            // {
            //     Console.WriteLine(x);
            // }

            //While Loops
            // var i = 0;
            // while (i <= 10)
            // {
            //     if (i % 2 == 0)
            //     {
            //         Console.WriteLine(i);
            //         
            //     }
            //
            //     i++;
            // }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;

            }
        }
    }
}