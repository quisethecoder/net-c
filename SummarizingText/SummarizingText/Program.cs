

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really long text.";
            var summary = StringUtility.summarizeText(sentence, 25);
            Console.WriteLine(summary);
        }

        
    }
}

