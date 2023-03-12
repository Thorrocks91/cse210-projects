using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("He");
        word.Show();
        word.Hide();
        word.Show();

    
        Reference reference = new Reference("book", "chapter", int.Parse(verse), "verseText");
        reference.Book();
        reference.Chapter();
        reference.Verse();
        reference.VerseText();


    }

       

        


        
        
        
    //     Scripture scripture = new Scripture();

    //     string userInput = "";

    //     List<string> menu  = new List<string>
    //     {
    //         "Press Enter",
    //         "Quit",
    //         "Press enter to continue or type 'quit' to exit: "
    //     };

    // while(userInput != "Quit")
    // {
    //     foreach(string userAnswer in menu)
    //     {
    //         Console.WriteLine(userAnswer);
    //     }
    //     userInput = Console.ReadLine();
    // }

    //     // This will start by displaying "AAA" and waiting for the user to press the enter key
    //     Console.WriteLine("AAA");
    //     Console.ReadLine();

    //     // This will clear the console
    //     Console.Clear();

    //     // This will show "BBB" in the console where "AAA" used to be
    //     Console.WriteLine("BBB");
        
    }
}