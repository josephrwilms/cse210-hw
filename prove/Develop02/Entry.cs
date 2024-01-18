public class Entry {
    public string _date;
    public string _prompt;
    public string _entry;
    public string _mood;

    public void Display() {
        Console.WriteLine($"Date: {_date}. Prompt: {_prompt}");
        Console.WriteLine($"You felt: {_mood}.");
        Console.WriteLine($"Entry: {_entry}.");
    }
}