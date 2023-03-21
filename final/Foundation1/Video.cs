using System;

public class Video
{

    public string _title = "";
    public string _author = "";
    public int _length = 0;

    public void DisplayAll()
    {
        Console.WriteLine($"{_title} {_author} {_length}");
    }
}