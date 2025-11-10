public class Word
{
    private string original;
    public string Original => original;
    private bool isHidden;

    public Word(string text)
    {
        original = text;
        isHidden = false;
    }
    public bool IsHidden()
    {
        return isHidden;
    }
    public void Hide()
    {
        isHidden = true;
    }
    public void Show()
    {
        isHidden = false;
    }
    public void Toggle()
    {
        isHidden = !isHidden;
    }
    public void Reset()
    {
        isHidden = false;
    }

    public string GetDisplayText()
    {
        if (isHidden)
        {
            return new string('_', original.Length);
        }
        else
        {
            return original;
        }
    }
}