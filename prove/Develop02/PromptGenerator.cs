
class PromptGenerator
{
    List<Random> prompts;
   
   
    
    

    static PromptGenerator()
    {
        string prompt = "";
        Random randomnumber =  new Random();
        int randomPromptNumber = randomnumber.Next(1,3);

        if (randomPromptNumber == 1)
        {
            prompt = "What are three things you are grateful for?";
        }
        if (randomPromptNumber == 2)
        {
            prompt = "What is a small blessing that impacted your day?";
        }
        if (randomPromptNumber == 3)
        {
            prompt = "List the individuals who have impacted you most today and why?";
        }

    }


    public string GetRandomPrompt()//method 
    {
        return"";
    }
}
