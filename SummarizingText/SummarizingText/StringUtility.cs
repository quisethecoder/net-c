namespace SummarizingText;

public class StringUtility
{
    public static string summarizeText(string text, int maxLength = 20)
    {
        if (text.Length < maxLength)
        {
            return text;
        }
            
        var words = text.Split(' ');
        var totalCharacters = 0;
        var summaryWords = new List<String>();
            
        foreach (var word in words)
        {
            summaryWords.Add(word);
                
            totalCharacters += word.Length + 1;
            if (totalCharacters > maxLength)
            {
                break;
            }
        }
            
        return String.Join(" ", summaryWords) + "...";
            
    }
}