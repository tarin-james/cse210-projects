// Goal Tracker Program
// CSE 210
// The Earthworms 
// Contributers: Zach McLaughlin, Tarin James, Austin Jones
// A program that allows the user to create a goal and keep of their progress. 
// The program includes a point system to increase the engagement of the user.
// The user is able to create a simple, eternal, or checklist goal, and each track the goal differently.
// We exceeded expectations by creating a new goal called Long Term Goal, creates a goal with a 
// name, description, and date the user wants it completed by.

using System;
using System.ComponentModel.DataAnnotations;

public class ewLongTermGoal : ewGoal
{
    public string ewgoalType = "LongTermGoal";
    public string ewgoalDate;
    public override void ewManualLoad()
    {
        Console.Write("What is the name of your goal? ");
        ewgoalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        ewdescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with the goal? ");
        ewpointsOfGoal = int.Parse(Console.ReadLine());
        Console.Write("When would you like to complete this goal by? MM/DD/YYYY: ");
        ewgoalDate = Console.ReadLine();
        ewisCompleted = false;

        ewtheList = ewgoalType + ewgoalName + "," + ewdescription + "," + ewpointsOfGoal + "," + ewisCompleted + "," + ewgoalDate;
    }

    public override void ewAutomaticLoad(string automaticAddToList)
    {
        List<string> ewdataList = new List<string>();
        string[] ewsplitValues = { ",", ":" };
        string[] ewsplitData = automaticAddToList.Split(ewsplitValues, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in ewsplitData)
        {
            ewdataList.Add(word);
        }
        ewgoalName = ewsplitData[1];
        ewdescription = ewsplitData[2];
        ewpointsOfGoal = int.Parse(ewsplitData[3]);
        ewisCompleted = bool.Parse(ewsplitData[4]);

        ewtheList = ewgoalType + ewgoalName + "," + ewdescription + "," + ewpointsOfGoal + "," + ewisCompleted;
    }

    public override string ewToShort()
    {
        return ewgoalName;
    }

    public override string ewToLong()
    {
        return $"{ewcheckMark} {ewgoalName} ({ewdescription}) {ewgoalDate}";
    }

    public override string ewToFile()
    {
        return $"{ewgoalType}:{ewgoalName},{ewdescription},{ewpointsOfGoal},{ewisCompleted},{ewgoalDate}\n";
    }

    public override int ewrecordEvent()
    {
        if (!ewisCompleted)
        {
            ewisCompleted = true;
            ewcheckMark = "[X]";
            return ewpointsOfGoal;
        }
        Console.WriteLine("\nYou've accomplished this goal already");
        return 0;
    }

}