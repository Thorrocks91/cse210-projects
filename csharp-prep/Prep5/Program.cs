using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = squareNumber(userNumber);


        DisplayResult(userName, squaredNumber);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter you name: ");
        string name = Console.ReadLine();
        return name;

    }

    static int PromptUserNumber()
    {
        Console.Write("Please Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squareNumber(int number)
    {
        int square = number + number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
    
}