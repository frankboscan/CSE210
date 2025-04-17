public class SimpleGoal : Goal{
	public override void SetCheckBox(){
		if (_isComplete)
			_checkBox = "[x]";
		else
			_checkBox = "[ ]";
	}

	public override void Accomplish(){
		SetIsComplete();
		SetCheckBox();
		Console.WriteLine($"Congratulations! You earned {_points} points!");
	}

	public override int GetPointsEarned(){
		return _points;
	}

        public SimpleGoal(string name, string description, int points) : base(
			name, description, "[ ]", false){
                _name = name;
                _description = description;
                _points = points;
		_isComplete = false;
		SetCheckBox();
	}

}
