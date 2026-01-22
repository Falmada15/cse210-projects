public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _mood;

    public Entry(string date, string promptText, string entryText, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

    public string GetSaveFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_mood}";
    }

    public static Entry FromSaveFormat(string line)
    {
        string[] parts = line.Split("|");
        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}
