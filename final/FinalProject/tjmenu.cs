using System.ComponentModel.Design;
using System.Reflection.Metadata;

class tjmenu
{

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
                    break;

                case "2":
                    // Document a transaction (transaction.cs)
                    break;

                case "3":
                    // view different categories and amount spent in the category (categoryViewer.cs)
                    break;

                case "4":
                    // goal maker (goal.cs)
                    break;

                case "5":
                    // view goals
                    break;

                case "6":
                    // save
                    break;
                
                case "7":
                    //Load
                    break;
                
                case "8": 
                    Console.WriteLine("Have a great day!");
                    tjuserChoice = "7";
                    break;

                default:
                    Console.WriteLine("\nInvalid Response \nSelect a choice from the menu");
                    break;
            }
        }
    }

}
