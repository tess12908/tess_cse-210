using System.Linq; 

class Scripture{ 
    // Scripture class is meant to store, display, and hide words from a given scripture.
    // var for this class 

    private List<Word> _wordList = new List<Word>(); 
    private string _nephi = "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them"; 
    private string _moroni = "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."; 
    private string _dNc = "Look unto me in every thought; doubt not, fear not. Behold the wounds which pierced my side, and also the prints of the nails in my hands and feet; be faithful, keep my commandments, and ye shall inherit the kingdom of heaven. Amen."; 

    private readonly Stack<Word> _hidden = new(); 
    private readonly Stack<Word> _visible = new(); 

     
    public Scripture(string _userScriptureChoice) // constructor
    { 

        string nephi = _nephi; 
        string moroni = _moroni; 
        string dNc = _dNc; 
        string[] words;

        if (_userScriptureChoice == "a")
        {
            words = nephi.Split(' ');
        }
        else if (_userScriptureChoice == "b")
        {
            words = moroni.Split(' ');
        }
        else if (_userScriptureChoice == "c")
        {
            words = dNc.Split(' '); 
        }
        else 
        {
            Console.WriteLine("No right choice given, doing A "); 
            words = nephi.Split(' ');
        }
        foreach (string item in words)
        { 
            _wordList.Add(new Word(item, false)); 
        }

        Random rnd = new Random();
        List<Word> shuffled = _wordList.OrderBy(randomVar => rnd.Next()).ToList(); 
        shuffled.ForEach(_visible.Push); 
    }


    // private int RandomNumGen() // random num gen. and return a number from the list
    // { 
    //     Random rnd = new Random();
    //     int index = rnd.Next(_wordList.Count); 
    //     return index;  
    // }

    public void HideWords() // change the random number/word to hidden 
    {
        //int RandomNumberMethod = RandomNumGen(); 
        //_wordList[RandomNumberMethod].SetHidden(); 
        
        Word takenWord = _visible.Pop(); 
        takenWord.SetHidden(); 
        _hidden.Push(takenWord); 
        
    }

    public void UnhideWord()
    {
        Word takenWord = _hidden.Pop(); 
        takenWord.SetVisible(); 
        _visible.Push(takenWord); 
    }

    public void DisplayScripture() // show the scripture and show ___ for the hidden words in for each 
    { 
        _wordList.ForEach(word => Console.Write(word.GetText()+ " "));
    }


    public bool IsAllHiden() // check the bool if its hidden 
    {
        return _wordList.All(word => word.GetIsHidden());
    }

}