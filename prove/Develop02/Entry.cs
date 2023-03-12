
class Entry
{
    //attributes
    public string _date;
    public string _prompt;
    public string _response;
   

    //constructor
    static string GetDateTime()
    {
        string currentDateTime = "";
        currentDateTime = DateTime.Now.ToString("h:mm:ss tt yyyy-mm-dd");
        return currentDateTime;
    }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;

        //require date prompt and response prompt to be place here.
       
          
    }

    public void DisplayEntry()//method
    {
        //print a line w/3 attributes on them.
        Console.WriteLine(_date, _prompt, _response);

    }

    public string getEntryAsCSV()//method
    {
        return string.Format("{0}|{1}|{2}", _date, _prompt, _response);
    }

    
}