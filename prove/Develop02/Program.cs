using System;

class Program
{
static void Main(string[] args)
    {
   

        Journal journal = new Journal();
        int menuUserinput = 0;

        //Create menu and user variables
        List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write", 
                "2. Display", 
                "3. Load", 
                "4. Save", 
                "5. Quit", 
                "What would you like to do? "
            };

        // While user input is not 5
        //foreach loop writing out each item of the list. 
        while (menuUserinput !=5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());
        }
        // if (menuUserinput == 1)
        // {
        //     Console.WriteLine(promptgenerator);
        //     PromptGenerator promptgenerator = new PromptGenerator();
            
        // }    
        //Switch to user input    
    }
}