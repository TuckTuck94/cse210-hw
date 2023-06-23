public class Comment
{
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    public string CommenterName { get; set; }
    
    public string CommentText { get; set; }
}