using System.IO;

class SaveAndLoad
{
    public List<Entry> Load() {
        Console.WriteLine("What is the file name? ");
        string userFileName = Console.ReadLine();
        userFileName = userFileName + ".csv";

        string[] _lines = System.IO.File.ReadAllLines(userFileName);
        List<Entry> loadedEntries = new List<Entry> {};  
        foreach(string line in _lines)
        {
            if (line.Length > 0) {
                string[] entryAttributes = line.Split(",");
                Entry newEntry = new Entry();
                newEntry._date = entryAttributes[0];
                newEntry._prompt = entryAttributes[1];
                newEntry._response = entryAttributes[2];

                loadedEntries.Add(newEntry);
            }
        
        } 
        return loadedEntries;
    }

    public void Save(List<Entry> entriesToSave) { 
        Console.WriteLine("What is the file name? ");
        string userFileName = Console.ReadLine();
        userFileName = userFileName + ".csv";
        string entriesToSaveString = "";
        foreach (Entry entryToSave in entriesToSave) 
        {   
            string response = $"\"{entryToSave._response.Replace("\"", "\"\"")}\"";

            entriesToSaveString += $"{entryToSave._date},{entryToSave._prompt},{response}\n";
        }

        using (StreamWriter outputFile = new StreamWriter(userFileName))

         
        outputFile.WriteLine(entriesToSaveString);
    
    }
}