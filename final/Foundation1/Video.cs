using System;
using System.Collections.Generic;

public class Video
{
    public string _title; 
    public string _author; 
    public int _seconds; 
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int seconds)
    { 
        _title = title; 
        _author = author; 
        _seconds = seconds; 
        comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_seconds} seconds\nComments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment._name}: {comment._text}");
        }
        Console.WriteLine();
    }
}