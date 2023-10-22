// Scriptre Memorizer
// CSE 210
//The Earthworms 
//Contributers: Zach McLaughlin, Tarin James, Austin Jones
// An application that allows the user to give the program a scriptures removing words one by one to assist in memorization of said scripture
// We exceeded expectation by loading the scripture we use from a text file.

using System;

class EWProgram
{
    static void Main(string[] args)
    {
        EWScripture EWscripture = new EWScripture();
        EWscripture.EWRun();
    }
}
