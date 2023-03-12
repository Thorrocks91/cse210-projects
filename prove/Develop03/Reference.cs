class Reference 
{
    private string _chapter;
    private int _verse;
    private string _book;
    private string _verseText;
    private int _multiVerse;

    public Reference(string book, string chapter, int verse, string verseText, int multiVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseText = verseText;
        _multiVerse = multiVerse;

    }
    public void Book()
    {
        Console.WriteLine(_book);

    }
    public void Chapter()
    {
        Console.WriteLine(_chapter);

    }

    public void Verse()
    {
         Console.WriteLine(_verse);

    }
    public string VerseText()
    {
        return _verseText;

    }
}