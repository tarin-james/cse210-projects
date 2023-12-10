class tjmenu
{
    List<tjGoal> tjgoalList = new List<tjGoal>();
    tjquickBalance tjbalance = new tjquickBalance();

    List<tjtransaction> tjtransactions = new List<tjtransaction>();
    tjcategoryViewer tjcategory = new tjcategoryViewer();
    tjfinancialGoal tjfinancailGoal = new tjfinancialGoal();
    tjlifetimeGoal tjlifetimeGoal = new tjlifetimeGoal();
    tjsaveAndLoad tjsaveAndLoad = new tjsaveAndLoad();



    public void tjDisplayMenu()
    {

        string tjuserChoice = "";

        while (tjuserChoice != "8")
        {
            Console.Write("\nMenu options:\n 1. Quick Balance\n 2. Document Transaction\n 3. Category List\n 4. Create Goal \n 5. View Goals\n 6. Save\n 7. Load\n 8. Quit\n Select a choice from the menu: ");
            tjuserChoice = Console.ReadLine();
            switch (tjuserChoice)
            {

                case "1":
                    // View simple balance (quickBalance.cs)
                    tjbalance.tjquickDisplay(tjtransactions);

                    break;

                case "2":
                    // Document a transaction (transaction.cs)
                    Console.WriteLine("What is the title of your transaction? ");
                    string tjnewTransactionName = Console.ReadLine();
                    Console.WriteLine("What category does this transaction fall under? ");
                    string tjnewCategoryType = Console.ReadLine();
                    Console.WriteLine("What is the date of the transaction? ex MM/DD/YY");
                    string tjnewTransactionDate = Console.ReadLine();
                    Console.WriteLine("What was the amount spent or received? *exclude $* ");
                    int tjnewTransactionAmount = Convert.ToInt32(Console.ReadLine());
                    tjtransaction tjtransaction = new tjtransaction();

                    tjtransaction.tjtransactionName = tjnewTransactionName;
                    tjtransaction.tjcategoryType = tjnewCategoryType;
                    tjtransaction.tjtransactionDate = tjnewTransactionDate;
                    tjtransaction.tjtransactionAmount = tjnewTransactionAmount;
                    tjtransactions.Add(tjtransaction);
                    break;

                case "3":
                    // view different categories and amount spent in the category (categoryViewer.cs)
                    Console.WriteLine("Would you like to view Income (1) or Spending (2)? ");
                    string tjcategoryChoice = Console.ReadLine();
                    if (tjcategoryChoice == "1"){
                        tjcategory.tjdisplayIncomeCategories(tjtransactions);
                    }
                    else if (tjcategoryChoice == "2") {
                        tjcategory.tjdisplaySpendingCategories(tjtransactions);
                    }
                    else {
                        Console.WriteLine("Invalid Entry");
                    }


                    break;

                case "4":
                    // goal maker (goal.cs)
                    Console.WriteLine("What kind of goal would you like to make?\n");
                    Console.WriteLine("1. Financial Goal");
                    Console.WriteLine("2. Lifetime Goal");
                    Console.Write("\nSelect a choice: ");
                    string tjgoalchoice = Console.ReadLine();
                    if (tjgoalchoice == "1") {
                        tjfinancialGoal tjfinancialGoal = new tjfinancialGoal();
                        tjfinancialGoal.tjgoalCreation();
                        tjgoalList.Add(tjfinancialGoal);

                    }

                    else if (tjgoalchoice == "2") {
                        tjlifetimeGoal tjlifetimeGoal = new tjlifetimeGoal();
                        tjlifetimeGoal.tjgoalCreation();
                        tjgoalList.Add(tjlifetimeGoal);
                    }
                    break;

                case "5":
                    // view goals
                    Console.Clear();
                    Console.WriteLine("\nCurrent Goals:");
                    foreach (var goal in tjgoalList)
                    {
                        Console.WriteLine(goal.tjdisplayGoal());
                    }
                    Console.WriteLine("\nPress enter to continue: ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                    

                case "6":
                    // save
                    tjsaveAndLoad.tjsave(tjgoalList, tjtransactions);
                    break;

                case "7":
                    Console.WriteLine("What is the file name? ");
                    string tjfileName = Console.ReadLine();
                    tjfileName = tjfileName + ".txt";
                    tjtransactions = tjsaveAndLoad.tjloadTransaction(tjfileName);
                    tjgoalList = tjsaveAndLoad.tjloadGoal(tjfileName);
          
                    break;

                case "8":
                    Console.WriteLine("\nHave a great day!");
                    tjuserChoice = "8";
                    break;

                default:
                    Console.WriteLine("\nInvalid Response \nSelect a choice from the menu");
                    break;
            }
        }
    }

}
