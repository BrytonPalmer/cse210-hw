class Comment
{
    private string name;
    private string text;
    private List<Comment> replies;

    public Comment(string aName, string aText)
    {
        name = aName;
        text = aText;
        replies = new List<Comment>();
    }

    public string GetName()
    {
        return name;
    }

    public string GetText()
    {
        return text;
    }

    public void AddReply(Comment comment)
    {
        replies.Add(comment);
    }

    public List<Comment> GetReplies()
    {
        return replies;
    }

    public override string ToString()
    {
        return $"{name}: {text}";
    }

    public void DisplayReplies(int indent = 1)
    {
        string indentation = new string(' ', indent * 2);
        foreach (Comment reply in replies)
        {
            Console.WriteLine($"{indentation}- {reply}");
            reply.DisplayReplies(indent + 1);
        }
    }
}