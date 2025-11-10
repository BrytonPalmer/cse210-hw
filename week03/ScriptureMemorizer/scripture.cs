
public class Scripture
{
    private List<Word> words;
    private Reference reference;
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text
            .Split(' ')
            .Select(wordText => new Word(wordText))
            .ToList();
    }
    public string GetReference()
    {
        return reference.GetReference();
    }
    public string GetFullText()
    {
        return string.Join(" ", words.Select(w => w.Original));
    }
    public void HideRandomWords(int count = 2)
    {
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();
        Random random = new Random();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public void ResetWords()
    {
        foreach (var word in words)
        {
            word.Reset();
        }
    }
    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }
    public void ToggleWordAt(int index)
    {
        if (index >= 0 && index < words.Count)
        {
            words[index].Toggle();
        }
    }
    public void RevealAllWords()
    {
        foreach (var word in words)
        {
            word.Show();
        }
    }
    public string GetDisplayText()
    {
        return string.Join(" ", words.Select(w => w.GetDisplayText()));
    }
}

