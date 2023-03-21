using System;

public class Video
{

    private string _title = "";
    private string _author = "";
    private int _length = 0;

    public void DisplayAll()
    {
        Console.WriteLine($"{_title} {_author} {_length}");
    }
}