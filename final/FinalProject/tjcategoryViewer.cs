

class tjcategoryViewer
{

    public void tjdisplayIncomeCategories(List<tjtransaction> tjtransactionList)
    {
        Console.WriteLine("\nIncome Category List: \n");
        foreach (tjtransaction transaction in tjtransactionList)
        {
            if (transaction.tjtransactionAmount > 0)
            {
                Console.WriteLine($"{transaction.tjtransactionDate} - {transaction.tjcategoryType} + {transaction.tjtransactionAmount}");
            }
        }
    }

    public void tjdisplaySpendingCategories(List<tjtransaction> tjtransactionList)
    {
        Console.WriteLine("\nSpending Category List: \n");
        foreach (tjtransaction transaction in tjtransactionList)
        {
            if (transaction.tjtransactionAmount < 0)
            {
                Console.WriteLine($"{transaction.tjtransactionDate} - {transaction.tjcategoryType} {transaction.tjtransactionAmount}");
            }
        }

    }
}