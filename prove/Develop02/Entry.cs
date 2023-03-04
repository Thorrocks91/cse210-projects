
class Entry
{
    //attributes
    public string date;
    public string prompt;
    public string response;
   

    //constructor
    static string GetDateTime()
    {
        string currentDateTime = "";
        currentDateTime = DateTime,Now,ToString("h:mm:ss tt yyyy-mm-dd");
        return currentDateTime;
    }

    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;

        //require date prompt and response prompt to be place here.
       
          
    }

    public void DisplayEntry()//method
    {
        //print a line w/3 attributes on them.
        Console.WriteLine(date, prompt, response);

    }

    public string getEntryAsCSV()//method
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }

    
}