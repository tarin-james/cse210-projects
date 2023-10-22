// Scriptre Memorizer
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
// An application that allows the user to give the program a scriptures removing words one by one to assist in memorization of said scripture
// We exceeded expectation by loading the scripture we use from a text file.

using System;

public class EWScripture
{
    private EWReference EWreference;
    private bool EWdone = false;
    private string EWinput;

    public EWScripture() {
        EWreference = new EWReference(this);
    }
    public void EWQuit() {
        EWdone = true;
    }
    public void EWRun()
    {
        Console.Clear();
        while (!EWdone)
        {
            EWreference.EWDisplay();
            EWinput = Console.ReadLine();
            Console.Clear();
            EWreference.EWEnterPressed();
            if (EWinput == "quit")
            {
                EWQuit();
            }
        }    
    }
}
