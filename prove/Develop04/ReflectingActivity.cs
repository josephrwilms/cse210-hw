public class ReflectingActivity : Activity {
    private List<String> _prompts = new List<string>();
    private List<String> _questions = new List<string>();

    public ReflectingActivity() {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run() {
        DisplayStartingMessage();
        ShowSpinner(5);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        DisplayPrompt();

        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        
        while (_duration > 0)
        {
            DisplayQuestions();
            _duration -= 10;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt() {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public string GetRandomQuestion() {
        Random rnd = new Random();
        return _questions[rnd.Next(_questions.Count)];
    }

    public void DisplayPrompt() {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
    }

    public void DisplayQuestions() {
        Console.WriteLine($"{GetRandomQuestion()}");
        ShowSpinner(10);
        Console.WriteLine("");
    }
}