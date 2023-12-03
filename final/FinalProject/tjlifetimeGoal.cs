public  class tjlifetimeGoal : tjGoal
{
    public string ewgoalType = "EternalGoal"; 
    public override void tjgoalCreation()
    {
        Console.Write("What is the name of your goal? ");
        tjgoalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        tjdescription = Console.ReadLine();
        tjisCompleted = false;

        tjgoalList =  ewgoalType + tjgoalName + "," + tjdescription;
    }
    public override void ewAutomaticLoad(string automaticAddToList)
    {   
        List<string> tjdataList = new List<string>(); 
        string[] tjsplitValues = {"," , ":"};
        string[] tjsplitData = automaticAddToList.Split(tjsplitValues, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in tjsplitData){
            tjdataList.Add(word);
        }
        tjgoalName = tjsplitData[1];
        tjdescription = tjsplitData[2];
         = int.Parse(tjsplitData[3]);

        tjgoalList = ewgoalType + tjgoalName + "," + tjdescription;
    }
    

    public override string tjgoalToString()
    {
        return  $"{tjgoalName} ({tjdescription})";
    }

    public override string tjgoalToString()
    {
        return $"{ewgoalType}:{tjgoalName},{tjdescription}\n";
    }


}