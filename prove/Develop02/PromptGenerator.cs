public class PromptGenerator {
    private string[] _prompts = {"What was your favorite part of the day", 
    "What is something new you learned about someone today", 
    "How did you feel today?", 
    "What is something you wished you could do better from today",
    "In what way did you improve today?"};

    Random rnd = new Random();

    public string GetRandomPrompt() {
        return _prompts[rnd.Next(0, _prompts.Length - 1)];
    }

}