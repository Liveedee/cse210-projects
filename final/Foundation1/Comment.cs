using System;

public class Comment
{
    public List<Comment> Comments = new List<Comment>();

    public string _commenter;
    public string _comment;
    public int _commentAmount;

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"Commenter: {_commenter}, Comment Made: {_comment}, Number of Comments: {_commentAmount}");
    

    
    foreach(Comment comment in Comments)
    {
        comment.DisplayCommentInfo();
    }


    }
}