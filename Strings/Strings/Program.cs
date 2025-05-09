// See https://aka.ms/new-console-template for more information

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var firstName = "Moshquise";
            var lastName = "Dawki";
            
            var fullName = firstName + " " + lastName;
            
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John 
                        Look into the following paths 
                        c:\folder1\folder2\folder3";
            Console.WriteLine(text);

        }
    }
}