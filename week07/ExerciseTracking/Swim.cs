public class Swim : Activity{
        private int _laps;

        public Swim(string date, int minutes, int laps) : base(date, minutes){
                _laps = laps;
        }

	public int GetLaps(){
		return _laps;
	}

        public override double GetDistance(){
                return _laps * 50 / 1000;
        }

	public override double GetSpeed(){
		return GetDistance() / _minutes * 60;
	}

	public override double GetPace(){
		return 60 / GetSpeed();
	}
}
