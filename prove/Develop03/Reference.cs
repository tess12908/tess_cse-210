class Reference
{
    // var for this class 
    private string _book; 
    private string _chapter; 
    private int _verse; 
    private int _verseEnd; 

    public Reference(string book, string chapter, int  verse, int endVerse) // constructor 
    {
        book = _book; 
        chapter = _chapter; 
        verse = _verse; 
        endVerse = _verseEnd; 
    }

    public void DisplayLongReference() // Display constructor if scripture is longer then one verse  
    {
        Console.WriteLine($"{_book} {_chapter}: {_verse} - {_verseEnd}"); 
    }

    public void DisplayShortReference() // Display constructor if scripture is only one verse 
    {
        Console.WriteLine($"{_book} {_chapter}: {_verse}"); 
    }


}