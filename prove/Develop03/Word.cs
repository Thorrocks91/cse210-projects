class Word
{
     //attributes
    private string _word;
    private bool _shown;
    //constructors
    public Word(string word)
    {
        _word = word;  
        _shown = true;    
    }

    public void Show()
    {
        Console.WriteLine(_word);
    }

    public void Hide()
    {
        char[] letters = _word.ToCharArray();
        for(int i = 0; i<letters.Length; i++ )
        {
            letters[i]='_';
        }

        _word = new string(letters);  
        _shown = false;
    }
    
    public bool GetShown()
    {
        return _shown;

    }

    public string GetWord()
    {
        return _word;
    }


    
}
    //methods
    //getter for word. 

    
   