using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName,topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"Title{_title}";
    }

}