using System;

public class Entries {
    List<string> prompts = new List<string> {"What was the best part of my day? ", "What do I wish I would have done today? ", "How do I want to improve myself for tomorrow? ", "What is one of my favorite memories? ", "Whats a couple thing I'm greatful for? "};
    public List<Entry> entries = new List<Entry> {};
    public void GetEntry() {
        var newRandom = new Random();
        string randomPrompt = prompts[newRandom.Next(4)];
        Console.WriteLine(randomPrompt);
        Console.WriteLine("Enter Response Here: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry.prompt = randomPrompt;
        newEntry.response = response;
        entries.Add(newEntry);
        // foreach(Entry entry in entries){
        // Console.WriteLine(entry.response);
        // }
            }

    public void Display() {
        foreach(Entry entry in entries) {
            Console.WriteLine($"\n{entry.date} - Prompt: {entry.prompt}\n{entry.response}");
        }
    }
    
}

