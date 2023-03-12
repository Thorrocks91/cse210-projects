public class Scripture 
{
    //list of word objects and hiding some of them need to loop through them. 
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public Scripture(string book, string chapter, string verse, string verseText, int multiVerse)
    {
        if(verse.Contains("-"))
        {
            string[]_multiVerse = verse.Split("-");
            _reference = new Reference(book, chapter, int.Parse(multiVerse[0]), int.Parse(multiVerse[1]));
        }
        else
        {
            _reference = new Reference(book, (chapter), int.Parse(verse), verseText,int.Parse(multiVerse[0]));
        }
        foreach (string word in verseText.Split("."))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

    }
    

}