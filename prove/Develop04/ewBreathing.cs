// Mindfulness Program
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
//A program to allow the user to help the user relax and take a break from everyday
//life for a moment. The user is able to step through three different exercises to clear
//their minds and become more mindful


using System;

class ewBreathing : ewMessage
{

    private bool ewDone = false;

    public void ewStartBreathingActivity(){
        ewactivityName = "Reflecting";
        ewStartMessage();

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        ewactivityLength = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Get Ready ...");
        ewLoadingAnimation(1);


        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(Double.Parse(ewactivityLength));
        DateTime halfTime = currentTime.AddSeconds(Double.Parse(ewactivityLength)/2);
        int ewBreathCount = 2;

        while (currentTime < endTime)
        {
            Console.Write("\n> ");
            currentTime = DateTime.Now;
            if (currentTime < halfTime){
                Console.Write("Breathe In...");
                ewCountDown(ewBreathCount);
                Console.Write("Breathe Out...");
                ewCountDown(ewBreathCount);
                ewBreathCount++;
            } else {
                Console.Write("Breathe In...");
                ewCountDown(ewBreathCount);
                Console.Write("Breathe Out...");
                ewCountDown(ewBreathCount);
                ewBreathCount--;
            }
            Console.WriteLine(" \n ");
        }

        ewDisplayEndMessage();
        ewDone = true;
}
public void ewCountDown(int numberOfLoops)
    {
        int ewDisplayCountdownNumber = numberOfLoops;
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write(ewDisplayCountdownNumber);
            ewDisplayCountdownNumber--;
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine(" \n ");

    }
}
