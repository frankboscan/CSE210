public abstract class Goal{
	protected string _name, _description, _checkBox;
	protected bool _isComplete;
	protected int _points;

	public abstract void Accomplish();
	public abstract void SetCheckBox();
	public abstract int GetPointsEarned();

	public Goal(string name, string description, string checkbox, bool isComplete){
		_name = name;
		_description = description;
	}

	public void SetIsComplete(){
		_isComplete = true;
	}

	public string GetCheckBox(){
		return _checkBox;
	}

	public string GetDetailsString(){
		return $"{_checkBox} {_name}, {_points} points: {_description}";
	}
}
