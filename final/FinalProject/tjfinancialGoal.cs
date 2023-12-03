
public class tjfinancialGoal : tjGoal
{
    public string tjgoalType = "FinancialGoal";
    public override void tjgoalCreation()
    {
        Console.Write("What is the name of your goal? ");
        tjgoalName = Console.ReadLine();
        Console.Write("What do you hope to accompish with this goal? ");
        tjdescription = Console.ReadLine();
        tjisCompleted = false;

        tjgoalList = tjgoalType + tjgoalName + "," + tjdescription + "," + tjisCompleted;
    }

    public override void ewAutomaticLoad(string automaticAddToList)
    {
        List<string> tjdataList = new List<string>();
        string[] tjsplitValues = { ",", ":" };
        string[] tjsplitData = automaticAddToList.Split(tjsplitValues, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in tjsplitData)
        {
            tjdataList.Add(word);
        }
        tjgoalName = tjsplitData[1];
        tjdescription = tjsplitData[2];
        tjisCompleted = bool.Parse(tjsplitData[4]);

        tjgoalList = tjgoalType + tjgoalName + "," + tjdescription + "," + tjisCompleted;
    }


    public override string tjdisplayGoal()
    {
        return $"{tjcheckMark} {tjgoalName} ({tjdescription})";
    }

    public override string tjgoalToString()
    {
        return $"{tjgoalType}:{tjgoalName},{tjdescription},{tjisCompleted}\n";
    }

    public  int tjrecordEvent()
    {
        if (!tjisCompleted)
        {
            tjisCompleted = true;
            tjcheckMark = "[X]";
        }
        Console.WriteLine("\nYou've accomplished this goal already");
        return 0;
    }

}