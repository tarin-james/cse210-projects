// Goal Tracker Program
// CSE 210
// The Earthworms 
// Contributers: Zach McLaughlin, Tarin James, Austin Jones
// A program that allows the user to create a goal and keep of their progress. 
// The program includes a point system to increase the engagement of the user.
// The user is able to create a simple, eternal, or checklist goal, and each track the goal differently.
// We exceeded expectations by creating a new goal called Long Term Goal, creates a goal with a 
// name, description, and date the user wants it completed by.

using System.Text.RegularExpressions;

public class ewMenu
{
    // private int ewTotalPoints;
    List<ewGoal> ewgoalList = new List<ewGoal> { };
    bool ewDone = false;
    int ewUserChoice;
    ewSaveLoad ewsaveLoader = new ewSaveLoad();
    int ewtotalPoints = 0;

    private void ewDisplayMenu()
    {
        Console.WriteLine($"\nYou have {ewtotalPoints} points\n");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void ewrunMenu()
    {
        while (!ewDone)
        {
            ewDisplayMenu();
            ewUserChoice = Convert.ToInt32(Console.ReadLine());
            switch (ewUserChoice)
            {
                // 1. Create New Goal
                case 1:
                    Console.Clear();
                    Console.WriteLine("Choose goal type:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("  4. Long Term Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int ewgoalTypeChoice = Convert.ToInt32(Console.ReadLine());
                    ewGoal ewnewGoal;

                    switch (ewgoalTypeChoice)
                    {
                        case 1:
                            ewnewGoal = new ewSimpleGoal();
                            ewnewGoal.ewManualLoad();
                            break;
                        case 2:
                            ewnewGoal = new ewEternalGoal();
                            ewnewGoal.ewManualLoad();
                            break;
                        case 3:
                            ewnewGoal = new ewChecklistGoal();
                            ewnewGoal.ewManualLoad();
                            break;
                        
                        case 4:
                            ewnewGoal = new ewLongTermGoal();
                            ewnewGoal.ewManualLoad();

                            break;

                        default:
                            Console.WriteLine("\nInvalid goal type choice.");
                            continue;
                    }

                    // Add the new goal to your list or do whatever you want with it
                    // For example, add it to the groupList in your Main method
                    ewgoalList.Add(ewnewGoal);
                    break;

                // 2. List Goals
                case 2:
                    Console.Clear();
                    Console.WriteLine("List of Goals:");
                    foreach (var goal in ewgoalList)
                    {
                        Console.WriteLine(goal.ewToLong());
                    }
                    Console.WriteLine("\nPress enter to continue: ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                // 3. Save Goals
                case 3:
                    ewsaveLoader.ewSave(ewgoalList, ewtotalPoints.ToString());
                    break;

                // 4. Load Goals
                case 4:
                    ewgoalList = ewsaveLoader.ewLoad();
                    ewtotalPoints = ewsaveLoader.ewloadedPoints;
                    break;
                // 5. Record Event
                case 5:
                    Console.WriteLine("\nThe goals are: ");

                    for (int i = 0; i < ewgoalList.Count; i++)
                    {
                        ewGoal goal = ewgoalList[i];
                        Console.WriteLine($"{i + 1}. {goal.ewToShort()}");
                    }

                    Console.Write("\nWhich goal did you accomplish? ");
                    int ewaccomplishedGoal = int.Parse(Console.ReadLine()) - 1;
                    // [ewSimpleGoal, ewEternalGoal, ...etc]
                    // 1. ewSimpleGoal
                    // 2. ewEternalGoal
                    if (ewgoalList.Count >= ewaccomplishedGoal)
                    {
                        ewGoal ewgoalToModify = ewgoalList[ewaccomplishedGoal];
                        int ewpointsToAdd = ewgoalToModify.ewrecordEvent();
                        ewtotalPoints += ewpointsToAdd;
                        if (ewpointsToAdd > 0)
                        {
                            Console.WriteLine($"\nCongratulations! You have earned {ewpointsToAdd} points.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid value");
                    }
                    break;
                // 6. Quit
                case 6:
                    ewDone = true;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid input, please try again.");
                    Console.Write("\nPress enter to continue: ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}