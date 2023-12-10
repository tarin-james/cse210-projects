
public class tjfinancialGoal : tjGoal
{
    public string tjgoalType = "FinancialGoal";
    public override void tjgoalCreation()
    {
        Console.Write("What is the name of your goal? ");
        tjgoalName = Console.ReadLine();
        Console.Write("What do you hope to accompish with this goal? ");
        tjdescription = Console.ReadLine();

        tjgoalList = tjgoalType + tjgoalName + "," + tjdescription;
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
        tjgoalType = tjsplitData[0];
        tjgoalName = tjsplitData[1];
        tjdescription = tjsplitData[2];
      

        tjgoalList = tjgoalType + "," + tjgoalName + "," + tjdescription;
    }


    public override string tjdisplayGoal()
    {
        return $"{tjgoalType} {tjgoalName} ({tjdescription})";
    }

    public override string tjgoalToString()
    {
        return $"{tjgoalType},{tjgoalName},{tjdescription}\n";
    }

}