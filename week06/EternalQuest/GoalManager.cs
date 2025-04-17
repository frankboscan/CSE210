public class GoalManager{
	private int _pointGoal, _points, _goalsCompleted;
	private List<Goal> _goals = new List<Goal>();

	public GoalManager(int points, int goal, int goalsCompleted){
		_points = points;
		_pointGoal = goal;
		_goalsCompleted = goalsCompleted;
	}

	public void AddPoints(int points){
		_points += points;
	}

	public void SetPointGoal(int points){
		_pointGoal += points;
	}

	public int GetPoints(){
		return	_points;
	}

	public int GetPointGoal(){
		return _pointGoal;
	}

	public void AddGoal(Goal goal){
		_goals.Add(goal);
	}

	public List<Goal> GetGoals(){
		return _goals;
	}

	public void ShowGoals(){
		Console.WriteLine($"\n{GetProgress()}\n");
		for (int i = 0; i < _goals.Count; i++)
			Console.WriteLine($"{i}: {_goals[i].GetDetailsString()}");
	}

	public string ShowGoal(int i){
		return _goals[i].GetDetailsString();
	}

	public string GetProgress(){
		return $"Goals completed: {_goalsCompleted}. Current points: {_points} out of {_pointGoal} (goal).";
	}

	public void Accomplish(int i){
		_goals[i].Accomplish();
		_points += _goals[i].GetPointsEarned();
		_goalsCompleted++;
	}
}
