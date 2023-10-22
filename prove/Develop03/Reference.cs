// Scriptre Memorizer
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
// An application that allows the user to give the program a scriptures removing words one by one to assist in memorization of said scripture
// We exceeded expectation by loading the scripture we use from a text file.

using System;
using System.IO;
using System.Collections.Generic;

 
public class EWReference
{
    private List<EWWord> EWwordList = new List<EWWord>();
    Random EWrnd = new Random();
    EWScripture EWscrip;
    public EWReference(EWScripture scripture)
    {
        EWscrip = scripture;
        string EWfilePath = "scipture.txt";
        
        if (File.Exists(EWfilePath)) 
        {
            string[] EWlines = File.ReadAllLines(EWfilePath);
            
            foreach (string EWstringline in EWlines)
            {
                string[] EWwords = EWstringline.Split(' ');
                foreach (string EWword in EWwords)
                {
                    EWwordList.Add(new EWWord(EWword));
                }
            }
        }
        else 
        {
            Console.WriteLine("Scripture file doesnt exist.");
        }
    }

    public void EWDisplay() {
     Console.Write("Docterine and Covenants 6:35-36 ");
        foreach (EWWord EWword in EWwordList)
        {
            EWword.EWDisplay();
            Console.Write(' ');
        }
     Console.Write("\n\nPress enter to continue or type 'quit' to finish :");
   
    }

    public void EWEnterPressed() {
        EWwordList[EWrnd.Next(35)].EWshouldShowUnderscore = true;
        EWwordList[EWrnd.Next(35)].EWshouldShowUnderscore = true;
        EWwordList[EWrnd.Next(35)].EWshouldShowUnderscore = true;
        
        int EWnumberOfUnderscoreWords = 0;
        foreach (var EWword in EWwordList)
        {
            if (EWword.EWshouldShowUnderscore == true) {
                EWnumberOfUnderscoreWords += 1;
            }
        }
        if (EWnumberOfUnderscoreWords == EWwordList.Count) {
            EWscrip.EWQuit();
        }
    }
}