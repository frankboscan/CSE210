public class EternalGoal : Goal{
        public EternalGoal(string name, string description, int points) : base(
			name, description, "", false){
                _name = name;
                _description = description;
                _points = points;
                _isComplete = false;
        }

        public override void Accomplish(){
		SetCheckBox();
                Console.WriteLine($"Congratulations! You earned {_points} points!");
        }

	public override int GetPointsEarned(){
		return _points;
	}

	public override void SetCheckBox(){
		_checkBox = "[ETERNAL]";
	}
}
