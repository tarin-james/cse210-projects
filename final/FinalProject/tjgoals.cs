public abstract class tjGoal
{
    public string tjgoalName;
    public string tjdescription;
    public bool tjisCompleted;

    public string tjcheckMark = "[ ]";
    public string tjgoalList;

    public List<string> SaveToList(List<string> goalList){
        goalList.Add(tjgoalList);
        return goalList;

    }
    
    public abstract void tjgoalCreation();
    public abstract void ewAutomaticLoad(string automaticAddToList);
    public abstract string tjdisplayGoal();
    public abstract string tjgoalToString();

}