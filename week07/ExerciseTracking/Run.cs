public class Run : Activity{
	private double _distance;

	public Run(string date, int minutes, double distance) : base(date, minutes){
		_distance = distance;
	}

        public override double GetDistance(){
		return _distance;
	}
        public override double GetSpeed(){
		return _distance / _minutes * 60;
	}
		
        public override double GetPace(){
		return 60 / GetSpeed();
	}
}
