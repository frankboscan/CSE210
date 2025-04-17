using System;

class Program{
	static void Main(string[] args){
		List<Activity> activities = new List<Activity>{
			new Run("02 Jan 2025", 60, 10.2),
			new Swim("03 Jan 2025", 45, 30),
			new Bike("04 Jan 2025", 90, 20),
		};
		foreach (Activity activity in activities)
			Console.WriteLine(activity.GetSummary());
	}
}
