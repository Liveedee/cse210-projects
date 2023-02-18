using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "7.3";
    private string _problems = "8-9";

    public MathAssignment(string _studentName, string _topic, string _textbookSection, string _problems) : base(studentName,topic)
    {
        _textbookSection = _textbookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
