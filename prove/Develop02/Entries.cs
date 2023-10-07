using System;

public class Entries {
    List<string> _prompts = new List<string> {
        "What was the best part of my day? ", "What do I wish I would have done today? ",
        "How do I want to improve myself for tomorrow? ", "What is one of my favorite memories? ", 
        "Whats a couple thing I'm greatful for? "};
    public List<Entry> entries = new List<Entry> {};
    public void GetEntry() 
    {
        var newRandom = new Random();
        string randomPrompt = _prompts[newRandom.Next(4)];
        Console.WriteLine(randomPrompt);
        Console.WriteLine("Enter Response Here: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry._prompt = randomPrompt;
        newEntry._response = response;
        entries.Add(newEntry);
    }

    public void Display() 
    {
        foreach(Entry entry in entries) {
            Console.WriteLine($"\n{entry._date} - Prompt: {entry._prompt}\n{entry._response}");
        }
    }
    
}

