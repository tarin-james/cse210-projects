using System.IO;

class SaveAndLoad
{
    public List<Entry> Load() {
        Console.WriteLine("What is the file name? ");
        string userFileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(userFileName);
        List<Entry> loadedEntries = new List<Entry> {};  
        foreach(string line in lines)
        {
            if (line.Length > 0) {
                string[] entryAttributes = line.Split("~");
                Entry newEntry = new Entry();
                newEntry.date = entryAttributes[0];
                newEntry.prompt = entryAttributes[1];
                newEntry.response = entryAttributes[2];

                loadedEntries.Add(newEntry);
            }
        
        } 
        return loadedEntries;
    }

    public void Save(List<Entry> entriesToSave) { 
        Console.WriteLine("What is the file name? ");
        string userFileName = Console.ReadLine(); 
        string entriesToSaveString = "";
        foreach(Entry entryToSave in entriesToSave) {
            entriesToSaveString += $"{entryToSave.date}~{entryToSave.prompt}~{entryToSave.response}\n";
        }

        using (StreamWriter outputFile = new StreamWriter(userFileName))

         
        outputFile.WriteLine(entriesToSaveString);
    
    }

    
}