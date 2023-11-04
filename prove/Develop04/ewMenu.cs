// Mindfulness Program
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
//A program to allow the user to help the user relax and take a break from everyday
//life for a moment. The user is able to step through three different exercises to clear
//their minds and become more mindful

using System;


class ewMenu
{
    ewListing ewlistingActivity = new ewListing();

    ewReflecting ewreflectingActivity = new ewReflecting();

    ewBreathing ewBreathingActivity = new ewBreathing();

    
    public void ewDisplayMenu() {

        var ewRandom = new Random();
        int ewRandomChoice = ewRandom.Next(1,3);


        string EWuserChoice = "";

        while (EWuserChoice != "5") {
            if (EWuserChoice != "4"){
                Console.Write("\nMenu options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Random Activity \n 5. Quit\nSelect a choice from the menu: ");
                EWuserChoice = Console.ReadLine();
            } else {
                EWuserChoice = ewRandomChoice.ToString();
            }
            switch (EWuserChoice) {
                
                case "1":
                    ewBreathingActivity.ewStartBreathingActivity();
                break;

                case "2":
                    ewreflectingActivity.ewStartReflectingActivity();
                break;

                case "3":
                    ewlistingActivity.ewStartListingActivity();
                break;

                case "4":
                    EWuserChoice = "4";
                break;

                case "5":
                    EWuserChoice = "5";
                break;

                default:
                    Console.WriteLine("\nInvalid Response \nSelect a choice from the menu");
                break;
            }
        }
    }
}