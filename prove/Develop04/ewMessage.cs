// Mindfulness Program
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
//A program to allow the user to help the user relax and take a break from everyday
//life for a moment. The user is able to step through three different exercises to clear
//their minds and become more mindful

using System;

public class ewMessage
{
    public string ewactivityLength = "0";

    public string ewactivityName = "";

    public void ewStartMessage()
    {
        Console.Clear();


        Console.WriteLine($"Welcome to the {ewactivityName} Activity.\n");
    }
    public void ewStarting()
    {
        Console.Write("You may begin in: ");
        Console.Write("5");

        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("4");

        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("3");

        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("2");

        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("1");
        Console.Write("\b \b");

    }
    public void ewLoadingAnimation(int numberOfLoops)
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write(@"\");

            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write(@"\");

            Thread.Sleep(300);

            Console.Write("\b \b");

        }

    }

    public void ewDisplayEndMessage()
    {
        Console.WriteLine("\nWell Done!!");
        ewLoadingAnimation(1);
        Console.WriteLine($"\nYou have completed another {ewactivityLength} seconds of the {ewactivityName} Activity.");
        ewLoadingAnimation(1);
    }
}