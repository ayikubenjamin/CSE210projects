

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator _promptGenerator;

    public Journal(PromptGenerator promptGenerator)
    {
        _promptGenerator = promptGenerator;
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach( var entry in _entries)
            {
                writer.WriteLine($"{entry._date} /{entry._promptText} /{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        if (File.Exists(file))
        {
            string[] Lines = File.ReadAllLines(file);
            foreach(var line in Lines)
            {
                string [] parts = line.Split('/');
                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(newEntry);
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }


}
