public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager() {}

    public void DisplayPlayerInfo() {
        Console.WriteLine("");
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine("");
    }

    public void ListGoalNames() {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"{i+1}. {_goals[i]._shortName}");
        }
    }

    public void ListGoalDetails() {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"{i+1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal() {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        Console.WriteLine("");

        switch (input) {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case "3":   
                Console.Write("How many times does this goal need to be accomplished? ");
                int amount = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, amount, bonus);
                _goals.Add(checklistGoal);
                break;
        }
    }

    public void RecordEvent() {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int input = int.Parse(Console.ReadLine());

        if (_goals[input-1].IsComplete() == true) {
            Console.WriteLine("You may not complete an already completed goal");
        } else {
            _score += _goals[input-1].RecordEvent();
        }
    }

    public void SaveGoals() {
        Console.Write("What filename would you like to use for your goals? (Please include .txt at the end)");
        string saveFileName = Console.ReadLine();

        Console.WriteLine("Saving....");

        using (StreamWriter outputFile = new StreamWriter(saveFileName)) {
            outputFile.WriteLine($"{_score}");
            foreach (Goal g in _goals) {
                outputFile.WriteLine($"{g.GetDetailsString()}");
            }
        }

        Console.WriteLine("Saved!");
    }

    public void LoadGoals() {
        Console.WriteLine("What filename would you like to use? (Please include .txt at the end)");
        string readFileName = Console.ReadLine();

        Console.WriteLine("Loading from file...");

        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(readFileName);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++) {
            string line = lines[i];
            string[] parts = line.Split("~~");

            if (parts[0] == "SimpleGoal") {
                SimpleGoal newGoal = new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4]));
                _goals.Add(newGoal);
            } else if (parts[0] == "EternalGoal") {
                EternalGoal newGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(newGoal);
            } else if (parts[0] == "ChecklistGoal") {
                ChecklistGoal newGoal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6]));
                _goals.Add(newGoal);
            }
        }

        Console.WriteLine("Loaded journal successfully");
    }
}