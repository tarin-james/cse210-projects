using Microsoft.VisualBasic;

class tjsaveAndLoad
{

    public void tjsave(List<tjGoal> tjgoalList, List<tjtransaction> tjtransactionList)
    {
        Console.WriteLine("What is the file name? ");
        string tjfileName = Console.ReadLine();
        tjfileName = tjfileName + ".txt";
        string tjstringToSave = "";
        foreach (tjtransaction transaction in tjtransactionList)
        {
            tjstringToSave += transaction.tjtransactionSerialization();
            tjstringToSave += "\n";
        }
        tjstringToSave += "-";
        tjstringToSave += "\n";
        foreach (tjGoal goal in tjgoalList)
        {
            tjstringToSave += goal.tjgoalToString();
        }
        using (StreamWriter outputFile = new StreamWriter(tjfileName))


            outputFile.WriteLine(tjstringToSave);
    }

    public List<tjtransaction> tjloadTransaction(string tjfileName)
    {
        string[] tjlines = System.IO.File.ReadAllLines(tjfileName);
        bool tjendOfTransactions = false;
        List<tjtransaction> tjtransactionsToLoad = new List<tjtransaction>();
        foreach (string line in tjlines)
        {
            if (!tjendOfTransactions)
            {
                if (line == "-")
                {
                    tjendOfTransactions = true;
                }
                else
                {
                    string[] tjsplitLine = line.Split(",");
                    tjtransaction tjnewTransaction = new tjtransaction();
                    tjnewTransaction.tjtransactionName = tjsplitLine[0];
                    tjnewTransaction.tjcategoryType = tjsplitLine[1];
                    tjnewTransaction.tjtransactionDate = tjsplitLine[2];
                    tjnewTransaction.tjtransactionAmount = Convert.ToSingle(tjsplitLine[3]);
                    tjtransactionsToLoad.Add(tjnewTransaction);
                }

            }
        }
        return tjtransactionsToLoad;
    }

    public List<tjGoal> tjloadGoal(string tjfileName)
    {
        string[] tjlines = System.IO.File.ReadAllLines(tjfileName);
        bool tjstartOfGoals = false;
        List<tjGoal> tjgoalsToLoad = new List<tjGoal>();
        foreach (string line in tjlines)
        {
            if (tjstartOfGoals)
            {

                string[] tjsplitLine = line.Split(",");
                if (tjsplitLine[0] == "FinancialGoal")
                {
                    tjfinancialGoal tjnewGoal = new tjfinancialGoal();
                    tjnewGoal.tjgoalType = tjsplitLine[0];
                    tjnewGoal.tjgoalName = tjsplitLine[1];
                    tjnewGoal.tjdescription = tjsplitLine[2];
                    tjgoalsToLoad.Add(tjnewGoal);
                }
                else if (tjsplitLine[0] == "LifetimeGoal")
                {
                    tjlifetimeGoal tjnewGoal = new tjlifetimeGoal();
                    tjnewGoal.tjgoalType = tjsplitLine[0];
                    tjnewGoal.tjgoalName = tjsplitLine[1];
                    tjnewGoal.tjdescription = tjsplitLine[2];
                    tjnewGoal.tjgoalImportance = tjsplitLine[3];
                    tjgoalsToLoad.Add(tjnewGoal);
                }

            }
            if (line == "-")
            {
                tjstartOfGoals = true;
            }
        }
        return tjgoalsToLoad;
    }
}

