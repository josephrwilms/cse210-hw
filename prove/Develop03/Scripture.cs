public class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (var wordString in words) {
            Word newWord = new Word(wordString);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords() {
        List<Word> unHiddenWords = new List<Word>();
        foreach (var word in _words) {
            if (word.IsHidden() == false) {
                unHiddenWords.Add(word);
            }
        }

        if (unHiddenWords.Count > 0) {
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(unHiddenWords.Count + 1); i++) {
                unHiddenWords[rnd.Next(unHiddenWords.Count)].Hide();
            }
        }
    }

    public string GetDislayText() {
        string s = "";
        foreach (var word in _words) {
            s += word.GetDisplayText();
            s += " ";
        }  
        return s;
    }

    public bool IsCompletelyHidden() {
        bool allHidden = true;
        foreach (var word in _words) {
            if (word.IsHidden() == false) {
                allHidden = false;
            }
        }   
        return allHidden;
    }
}