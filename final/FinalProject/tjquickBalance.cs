using System.Diagnostics.Metrics;
using System.Transactions;

class tjquickBalance : tjtransaction
{

    public float tjtotalBalance = 0;

    private void tjcomputeBalance(List<tjtransaction> tjtransactionList)
    {
        float tjcounter = 0;
        foreach (tjtransaction transaction in tjtransactionList)
        {
           tjcounter += transaction.tjtransactionAmount;
        }
        tjtotalBalance = tjcounter;
    }
    public void tjquickDisplay(List<tjtransaction> tjtransactionList) {
        tjcomputeBalance(tjtransactionList);
        Console.WriteLine($"${tjtotalBalance}");
    }
}