using System;

public class Video
{
    public List<Video> Videos = new List<Video>();

    public string _title = "";
    public string _author = "";
    public int _length = 5;

    public void DisplayAll()
    {
        Console.WriteLine($"Video Title: {_title}, Video Author: {_author}, Video Length: {_length}");
    }
}