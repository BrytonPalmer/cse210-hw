public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;

    public Reference(string book, int chapter, int verse, int endVerse = -1)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = endVerse;
    }
    public string GetReference()
    {
        if (endVerse != -1)
        {
            return $"{book} {chapter}:{verse}-{endVerse}";
        }
        else
        {
            return $"{book} {chapter}:{verse}";
        }
    }
    
}