
class Word
{
    // var for this class 
    private string _text;
    private bool _isHidden;

    public Word(string text, bool isHidden) // constructor 
    {
        _text = text;
        _isHidden = isHidden;
    }

    public bool GetIsHidden() // if hidden = true/false then change the bool to match 
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public void SetHidden() // return the text 
    {
        _isHidden = true; 
    }

    public void SetVisible() // return the text 
    {
        _isHidden = false; 
    }


    public string GetText() // replace the word with _____ bool is false
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }





}