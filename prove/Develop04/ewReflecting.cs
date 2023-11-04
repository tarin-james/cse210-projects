// Mindfulness Program
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
//A program to allow the user to help the user relax and take a break from everyday
//life for a moment. The user is able to step through three different exercises to clear
//their minds and become more mindful

using System;

class ewReflecting : ewMessage
{
    private bool ewDone = false;

    public void ewStartReflectingActivity()
    {   

        ewactivityName = "Reflecting";
        ewStartMessage();


        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        ewactivityLength = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Get Ready ...");

        ewLoadingAnimation(1);

        List<string> ewreflectingQuestions = new List<string> {
            "--- Why was this experience meaningful to you? ---", "--- Have you ever done anything like this before? ---",
            "--- How did you get started? ---", "--- How did you feel when it was complete? ---", "--- What made this time different than other times when you were not as successful? ---",
            "--- What is your favorite thing about this experience? ---", "--- What could you learn from this experience that applies to other situations? ---",
            "--- What did you learn about yourself through this experience? ---", "--- How can  you keep this experience in mind in the future? ---"
        };

        List<string> ewreflectingPrompts = new List<string> {
            "--- Think of a time when you stood up for someone else. ---", "--- Think of a time when you did something really difficult. ---",
            "---Think of a time when you helped someone in need. ---", "--- Think of a time when you did something truly selfless. ---"
        };

        var ewrndInt = new Random();

        int randomInt = ewrndInt.Next(ewreflectingPrompts.Count);

        var ewquestion = new Random();



        Console.WriteLine($"\nConsider the folowing prompt:\n\n{ewreflectingPrompts[randomInt]}\n\nWhen you have something in mind, press enter to continue.\n");

        Console.ReadKey();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        ewStarting();



        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(Double.Parse(ewactivityLength));

        while (currentTime < endTime)
        {
            Console.Write("\n> ");
            currentTime = DateTime.Now;
            Console.WriteLine(ewreflectingQuestions[ewquestion.Next(ewreflectingQuestions.Count)]);
            ewLoadingAnimation(3);
        }

        ewDisplayEndMessage();
        ewDone = true;

    }
}