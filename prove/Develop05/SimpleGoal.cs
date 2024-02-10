public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base (name, description, points) {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, bool complete) : base (name, description, points) {
        _isComplete = complete;
    }

    public override int RecordEvent() {
        _isComplete = true;
        return int.Parse(_points);
    }

    public override bool IsComplete() {
        if (_isComplete == true) {
            return true;
        } else {
            return false;
        }
    }

    public override string GetDetailsString() {
        return $"SimpleGoal~~{_shortName}~~{_description}~~{_points}~~{_isComplete}";
    }

    public override string GetStringRepresentation() {
        if (IsComplete()) {
            return $"[X] {_shortName} ({_description})";
        } else {
            return $"[ ] {_shortName} ({_description})";
        }
    }
}