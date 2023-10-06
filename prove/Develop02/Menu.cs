using System;

public class Menu
{
    Entries entries = new Entries();
    private SaveAndLoad saveAndLoadHandler = new SaveAndLoad();
    public string userChoice;
    public List<string> _menuList = new List<string>() {"1. Write", "2. Display", "3. Load",
    "4. Save", "5. Quit"};

    public void DisplayMenu(){
    
        string userChoice = "";

        while (userChoice != "5") { 
            Console.WriteLine("\nPlease select one of the following choices:");
            foreach (string option in _menuList)
            {
                Console.WriteLine(option);

            }
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine(); 
            switch (userChoice) {
                
            
                case "1":
                    entries.GetEntry();
                
                break;

                case "2":
                    entries.Display();
                break;

                case "3":
                    entries.entries = saveAndLoadHandler.Load();
                break;

                case "4":

                    saveAndLoadHandler.Save(entries.entries);
                break;

                case "5":
                    Console.WriteLine("\nProgram Closing, come back soon!");
                break;

                default:
                Console.WriteLine("\nInvalid response \nPlease enter a whole number between 1 and 5.");
                break;
            }

            
        }
    }

    /*
    public void DisplayFile()
    {

    }

    public string CreateEntry()
    {
        return Entry;
    }

    public 
    */

}