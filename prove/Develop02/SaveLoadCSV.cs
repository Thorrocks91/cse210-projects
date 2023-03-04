

class SaveLoadCSV
{

    public void ReadFromCSV()
    {
        StreamReader streamReader = new StreamReader(filePath);
        while(!streamReader.EndOfStream)
        {
            x line = streamReader.ReaderLine();
            entriesInCSV.add(line.replace('|',' '));
        }
    }
    public void displayCSV()
    {
        foreach(string entry in entriesInCSV)
        {
            Console.Write(entry);
        }
    }

}