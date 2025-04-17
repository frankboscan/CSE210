public class ChecklistGoal : Goal{
	private int _timesCompleted, _timesToComplete, _bonus;

	public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonus) :
			base(name, description, "[0/0]", false){
		_name = name;
		_description = description;
		_points = points;
		_timesToComplete = timesToComplete;
		_bonus = bonus;
		_timesCompleted = 0;
		SetCheckBox();
	}

        public override void Accomplish(){
                _timesCompleted++;
		SetCheckBox();
                Console.WriteLine($"Congratulations! You earned {_points} points!");
		if (_timesCompleted == _timesToComplete)
			Console.WriteLine(
				$"Goal completed {_timesToComplete} times. Bonus: {_bonus} points.");
        }

	public override int GetPointsEarned(){
		if (_timesCompleted != _timesToComplete)
			return _points;
		return _bonus + _points;
	}

	public override void SetCheckBox(){
		_checkBox = $"[{_timesCompleted}/{_timesToComplete}]";
	}

	public void SetTimesCompleted(int timesCompleted){
		_timesCompleted = timesCompleted;
	}
	
	public int GetTimesCompleted(){
		return _timesCompleted;
	}

	public void SetTimesToComplete(int timesToComplete){
		_timesToComplete = timesToComplete;
	}

	public int GetTimesToComplete(){
		return _timesToComplete;
	}
}
