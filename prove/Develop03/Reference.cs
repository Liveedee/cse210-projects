// STORETHEREFERENCE
public class Reference

{

    private string _reference;
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string _book, string _chapter, string _startVerse)
    {    
        this._book = _book;
        this._chapter = _chapter;
        this._startVerse = _startVerse; 
        _endVerse = null;
        _reference = ($"{_book} {_chapter}:{_startVerse}"); 
    }
    public Reference(string _book, string _chapter, string _startVerse, string _endVerse)
    {    
        this._book = _book;
        this._chapter = _chapter;
        this._startVerse = _startVerse; 
        this._endVerse = _endVerse ;
        _reference = ($"{_book} {_chapter}:{_startVerse}-{_endVerse}"); 
    }
    public Reference()
    {
            
    }
    public void ShowReference()
    {

        Console.WriteLine(_reference);
    }
}
// dont use just getters for the book verse or chapters 

// should have multiple constructor