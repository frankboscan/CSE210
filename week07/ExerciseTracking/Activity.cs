public abstract class Activity{
	protected string _date;
	protected int _minutes;

	public Activity(string date, int minutes){
		_date = date;
		_minutes = minutes;
	}

	public string GetSummary(){
		return $"{_date} {GetType().Name} ({_minutes} min) - Distance {GetDistance():F2} km, Speed {GetSpeed():F2} km/h, Pace {GetPace():F2} min/km";
	}

	public virtual double GetDistance(){
		return 0;
	}

	public virtual double GetSpeed(){
		return 0;
	}

	public virtual double GetPace(){
		return 0;
	}
}
