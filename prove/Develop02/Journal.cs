
class Journal
{
    List<Entry> entries;

    
    
    public Journal()//constructor
    {
        entries = new List<Entry>();
    }


//methods....
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }  
    }
    
    public void CreateJournalEntry()
    {
        CreateJournalEntry();
    }

    public void SaveToCSV()
    {

    }

    public void LoadFromCSV()
    {

    }
}