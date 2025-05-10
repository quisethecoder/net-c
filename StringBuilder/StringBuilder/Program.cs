using System.Text;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder("Hello World");
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0,20)
                .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine("FirstChar: " + builder[0]);
        }
    }
}

