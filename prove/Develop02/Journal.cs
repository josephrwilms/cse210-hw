public class Journal {
    public List<Entry> _entires = new List<Entry>();

    public void AddEntry(Entry entry) {
        _entires.Add(entry);
        Console.WriteLine("Added journal entry");
    }

    public void DisplayAll() {

    }

    public void Save(String fileName) {

    }

    public void Load(string fileName) {
        
    }

}