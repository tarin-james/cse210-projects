// Mindfulness Program
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
//A program to allow the user to help the user relax and take a break from everyday
//life for a moment. The user is able to step through three different exercises to clear
//their minds and become more mindful

using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

public class ewListing : ewMessage
{
    private bool ewDone = false;

    int itemsListed = 0;

    public void ewStartListingActivity()
    {
        ewactivityName = "Listing";
        ewStartMessage();


        Console.WriteLine("This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        ewactivityLength = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Get Ready ...");

        ewLoadingAnimation(1);

        var ewrndInt = new Random();

        int ewrandomInt = ewrndInt.Next(4);
        
        List<string> ewprompts = new List<string> {
        "--- When have you felt the holy ghost this month? ---", "--- What are personal strengths of yours ---", 
        "--- Who are people that you have helped this week? ---", "--- Who are some of your personal heroes? ---"
        };

        Console.WriteLine($"\nList as many responses as you can to the folowing prompt:\n{ewprompts[ewrandomInt]}");

        ewStarting();




        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(Double.Parse(ewactivityLength));

        while (currentTime < endTime)
        {
            Console.Write("\n> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
            itemsListed += 1;
        }
        Console.WriteLine($"Youe listed {itemsListed} items!");
        ewDisplayEndMessage();
        ewDone = true;

    }
}