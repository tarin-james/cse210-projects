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
using System.Security.Cryptography.X509Certificates;

class ewSaveLoad
{
    public int ewloadedPoints;
    public List<ewGoal> ewLoad()
    {
        try
        {
            int ewcounter = 0;
            string ewpoints = "";
            Console.WriteLine("What is the file name? ");
            string ewuserFileName = Console.ReadLine();
            ewuserFileName = ewuserFileName + ".txt";     

            string[] ewlines = System.IO.File.ReadAllLines(ewuserFileName);
            List<ewGoal> ewloadedGoals = new List<ewGoal> { };
                foreach (string goal in ewlines)
            {
                if (ewcounter == 0)
                {
                    //goal is score on the first run of the loop
                    ewloadedPoints = int.Parse(goal);
                }
                else
                {
                // Ex goal
                // SimpleGoal:Give a talk,Speak in Sacrament meeting when asked,100,True
                    if (goal.Length > 0)
                    {
                    // Split by :
                        string[] ewgoalTypeAndData = goal.Split(":");
                        string ewgoalType = ewgoalTypeAndData[0];
                        string ewgoalData = ewgoalTypeAndData[1];
                    // ["SimpleGoal", "Give a talk,Speak in Sacrament meeting when asked,100,True"]
                        string[] ewgoalAttributes = ewgoalData.Split(",");
                    // Ex ewgoalAttributes
                    // ["Give a talk", "Speak in Sacrament meeting when asked" , "100" , "True"]

                        if (ewgoalType == "SimpleGoal")
                        {
                            ewSimpleGoal ewnewGoal = new ewSimpleGoal();
                            ewnewGoal.ewgoalName = ewgoalAttributes[0];
                            ewnewGoal.ewdescription = ewgoalAttributes[1];
                            ewnewGoal.ewpointsOfGoal = int.Parse(ewgoalAttributes[2]);
                            ewnewGoal.ewisCompleted = Convert.ToBoolean(ewgoalAttributes[3]);
                            ewloadedGoals.Add(ewnewGoal);
                        }
                        else if (ewgoalType == "EternalGoal")
                        {
                            ewEternalGoal ewnewGoal = new ewEternalGoal();
                            ewnewGoal.ewgoalName = ewgoalAttributes[0];
                            ewnewGoal.ewdescription = ewgoalAttributes[1];
                            ewnewGoal.ewpointsOfGoal = int.Parse(ewgoalAttributes[2]);
                            ewloadedGoals.Add(ewnewGoal);
                        }
                        else if (ewgoalType == "ChecklistGoal")
                        {
                            ewChecklistGoal ewnewGoal = new ewChecklistGoal();
                            ewnewGoal.ewgoalName = ewgoalAttributes[0];
                            ewnewGoal.ewdescription = ewgoalAttributes[1];
                            ewnewGoal.ewpointsOfGoal = int.Parse(ewgoalAttributes[2]);
                            ewnewGoal.ewbonusPoints = int.Parse(ewgoalAttributes[3]);
                            ewnewGoal.ewcompletionAmount = int.Parse(ewgoalAttributes[4]);
                            ewnewGoal.ewtimesDone = int.Parse(ewgoalAttributes[5]);
                            ewloadedGoals.Add(ewnewGoal);
                        }
                        else if (ewgoalType == "LongTermGoal") {
                        
                            ewLongTermGoal ewnewGoal = new ewLongTermGoal();
                            ewnewGoal.ewgoalName = ewgoalAttributes[0];
                            ewnewGoal.ewdescription = ewgoalAttributes[1];
                            ewnewGoal.ewpointsOfGoal = int.Parse(ewgoalAttributes[2]);
                            ewnewGoal.ewisCompleted = Convert.ToBoolean(ewgoalAttributes[3]);
                            ewnewGoal.ewgoalDate = ewgoalAttributes[4];
                            ewloadedGoals.Add(ewnewGoal);
                        }
                    }

                }
                ewcounter += 1;
            }
            Console.WriteLine("\nGoals loaded successfully!");
            
            return ewloadedGoals;
        }
        catch (System.Exception)
        {
            
            Console.WriteLine("\nSomething went wrong, please try again.");
            return new List<ewGoal> { };
        }
    }


    public void ewSave(List<ewGoal> ewgoalsToSave, string ewpoints)
    {

        try
        {
            Console.WriteLine("\nWhat is the file name? ");
            string ewuserFileName = Console.ReadLine();
            ewuserFileName = ewuserFileName + ".txt";
            string ewgoalsToSaveString = "";
            ewgoalsToSaveString += $"{ewpoints}\n";
            foreach (ewGoal ewsavedGoal in ewgoalsToSave)
            {
                ewgoalsToSaveString += ewsavedGoal.ewToFile();

            }
            using (StreamWriter outputFile = new StreamWriter(ewuserFileName))


                outputFile.WriteLine(ewgoalsToSaveString);
            Console.WriteLine("\nGoals saved successfully!");
        }
        catch (System.Exception)
        {

            Console.WriteLine("\nSomething went wrong, please try again.");
        }
    }
}