public  class tjlifetimeGoal : tjGoal
{
    public string tjgoalType = "LifetimeGoal"; 
    public override void tjgoalCreation()
    {
        Console.Write("What is the name of your goal? ");
        tjgoalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        tjdescription = Console.ReadLine();
        Console.Write("On a scale from 1 - 10, how important is this goal to you? ");
        tjgoalImportance = Console.ReadLine();
        tjgoalList =  tjgoalType + "," + tjgoalName + "," + tjdescription + "," + tjgoalImportance;
    }
    public override void ewAutomaticLoad(string automaticAddToList)
    {   
        List<string> tjdataList = new List<string>(); 
        string[] tjsplitValues = {"," , ":"};
        string[] tjsplitData = automaticAddToList.Split(tjsplitValues, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in tjsplitData){
            tjdataList.Add(word);
        }
        tjgoalType = tjsplitData[0];
        tjgoalName = tjsplitData[1];
        tjdescription = tjsplitData[2];
        tjgoalImportance = tjsplitData[3];

        tjgoalList = tjgoalType + "," + tjgoalName + "," + tjdescription + "," + tjgoalImportance;
    }
    

    public override string tjgoalToString()
    {
        return  $"{tjgoalType},{tjgoalName},{tjdescription},{tjgoalImportance}";
    }
        public override string tjdisplayGoal()
    {
        return  $"{tjgoalType} {tjgoalName} ({tjdescription}) {tjgoalImportance}/10";
    }

  

}