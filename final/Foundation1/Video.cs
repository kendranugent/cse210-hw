public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int TotalComments()
    {
        return Comments.Count;
    }

    public override string ToString()
    {
        string commentsStr = string.Join("\n", Comments);
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nNumber of comments: {TotalComments()}\nComments:\n{commentsStr}";
    }
}
