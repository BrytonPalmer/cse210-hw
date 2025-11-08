
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private Entry _lastAddedEntry;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        _lastAddedEntry = newEntry;
    }

    public void SearchByKeyword(string keyword)
    {
        var results = _entries.Where(e =>
            e.ToFileFormat().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);

        if (!results.Any())
        {
            Console.WriteLine("No entries matched your keyword.");
            return;
        }

        Console.WriteLine($"\nEntries containing \"{keyword}\":");
        foreach (var entry in results)
        {
            entry.Display();
        }
    }
    public void SearchByDate(string date)
    {
        var results = _entries.Where(e =>
            e.ToFileFormat().StartsWith(date));

        if (!results.Any())
        {
            Console.WriteLine($"No entries found for {date}.");
            return;
        }

        Console.WriteLine($"\nEntries from {date}:");
        foreach (var entry in results)
        {
            entry.Display();
        }
    }


    public void UndoLastEntry()
    {
        if (_lastAddedEntry != null && _entries.Contains(_lastAddedEntry))
        {
            _entries.Remove(_lastAddedEntry);
            Console.WriteLine("Last entry undone.");
            _lastAddedEntry = null;
        }
        else
        {
            Console.WriteLine("No entry to undo.");
        }
    }

    public void DeleteEntry(int index)
    {
        if (index >= 0 && index < _entries.Count)
        {
            _entries.RemoveAt(index);
            Console.WriteLine($"Entry at index {index} deleted.");
        }
        else
        {
            Console.WriteLine("Invalid index. No entry deleted.");
        }
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine($"Entry #{i + 1}:");
            _entries[i].Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
        Console.WriteLine($"Journal saved to {file}");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry entry = Entry.FromFileFormat(line);
            if (entry != null)
            {
                _entries.Add(entry);
            }
        }

        Console.WriteLine($"Loaded {_entries.Count} entries from {file}");
    }
}
