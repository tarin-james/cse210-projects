// Scriptre Memorizer
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
// An application that allows the user to give the program a scriptures removing words one by one to assist in memorization of said scripture
// We exceeded expectation by loading the scripture we use from a text file.

using System;

public class EWWord {
    /* 
    properties:
     - text
     - shouldShow

    methods: 
     - display
    */
    public string EWnewWord = "";

    public bool EWshouldShowUnderscore = false;

    public EWWord(string EWwordToSet) {
        EWnewWord = EWwordToSet;
    }

    public void EWDisplay() {
        if (EWshouldShowUnderscore == true) {
            foreach (var letter in EWnewWord)
            {
                Console.Write("_");
            }
        }
        else {
            Console.Write(EWnewWord);
        }
        
    }
}


