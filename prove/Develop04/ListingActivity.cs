public class ListingActivty : Activity {
    private int _count;
    private List<String> _prompts = new List<string>();

    public ListingActivty() {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run() {
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("Write as many response as you can to this follwoing prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        
        Console.WriteLine("You may begin in 5 seconds");
        ShowSpinner(5);

        List<string> userResponses = GetListFromUser();

        _count = userResponses.Count;

        Console.WriteLine($"Well done, you listed {_count} things!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt() {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();

        Console.WriteLine("");
        Console.WriteLine("You can start typing your responses. Press Enter on an empty line to finish.");

        DateTime startTime = DateTime.Now;
        TimeSpan timespan = TimeSpan.FromSeconds(_duration);

        while (DateTime.Now - startTime < timespan)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (string.IsNullOrEmpty(response))
            {
                break;
            }

            userResponses.Add(response);
        }

        Console.WriteLine("\nTime's up! Automatically finishing data collection.");

        return userResponses;
    }
}