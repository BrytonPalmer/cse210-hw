using System.Transactions;

class Video
{
    private string title;
    private string author;
    private double length;
    private List<Comment> comments;


    public Video(string aTitle, string aAuthor, double aLength)
    {
        title = aTitle;
        author = aAuthor;
        length = aLength;
        comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public double GetLength()
    {
        return length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

}