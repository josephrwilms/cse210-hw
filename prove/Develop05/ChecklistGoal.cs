public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points) {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amount) : base (name, description, points) {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;
    }

    public override int RecordEvent() {
        _amountCompleted += 1;
        if (IsComplete() == true) {
            return int.Parse(_points) + _bonus;
        } else {
            return int.Parse(_points);
        }
        
    }

    public override bool IsComplete() {
        if (_target <= _amountCompleted) {
            return true;
        } else {
            return false;
        }
    }

    public override string GetDetailsString() {
        return $"ChecklistGoal~~{_shortName}~~{_description}~~{_points}~~{_bonus}~~{_target}~~{_amountCompleted}";
    }

    public override string GetStringRepresentation() {
        if (IsComplete() == true) {
            return $"[X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        } else {
            return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        
    }
}