/* Added a goal tracker, visible when view current goals.
 * Tracker shows the lifetime number of goals completed. */

using System;

class Program{
	static void Main(string[] args){
		GoalManager manager = new GoalManager(0, 0, 0);
		Console.WriteLine("Welcome to your goal tracker!");
		Console.WriteLine($"Points so far: {manager.GetPoints()}");
		Console.WriteLine($"Goal: {manager.GetPointGoal()}");
		bool go = true;
		while (go){
			Console.WriteLine("\nSelect from the following options:");
			Console.WriteLine("0. Indicate goal completion");
			Console.WriteLine("1. Set new point objective");
			Console.WriteLine("2. Create new goal");
			Console.WriteLine("3. See current goals");
			Console.WriteLine("4. Load goals");
			Console.WriteLine("5. Save goals");
			Console.WriteLine("6. Quit");
			int option = int.Parse(Console.ReadLine());
			switch (option){
				case 0:
					Console.WriteLine("What goal (number) did you accomplish? ");
					manager.ShowGoals();
					manager.Accomplish(int.Parse(Console.ReadLine()));
					break;
				case 1:
					Console.WriteLine("How many points? ");
					manager.SetPointGoal(int.Parse(Console.ReadLine()));
					Console.WriteLine(manager.GetProgress());
					break;
				case 2:
					Console.WriteLine("What kind of goal? ");
					Console.WriteLine("1. Simple");
					Console.WriteLine("2. Eternal");
					Console.WriteLine("3. Checklist");
					int choice = int.Parse(Console.ReadLine());
					Console.WriteLine("Goal name: ");
					string name = Console.ReadLine();
					Console.WriteLine("Brief description: ");
					string description = Console.ReadLine();
					Console.WriteLine("Number of points: ");
					int points = int.Parse(Console.ReadLine());
					switch (choice){
						case 1:
							manager.AddGoal(
								new SimpleGoal(name, description, points));
							Console.WriteLine($"Added: {
								manager.ShowGoal(
									manager.GetGoals().Count - 1)}");
							break;
						case 2:
							manager.AddGoal(new EternalGoal(
								name, description, points));
							Console.WriteLine($"Added: {
								manager.ShowGoal(
									manager.GetGoals().Count - 1)}");
							break;
						case 3:
							Console.WriteLine("Times to complete: ");
							int timesToComplete = int.Parse(Console.ReadLine());
							Console.WriteLine("Bonus upon completion: ");
							int bonus = int.Parse(Console.ReadLine());
							manager.AddGoal(new ChecklistGoal(
								name, description, timesToComplete,
								points, bonus));
							Console.WriteLine($"Added: {
								manager.ShowGoal(
									manager.GetGoals().Count - 1)}");
							break;
						default:
							Console.WriteLine("Invalid option.");
							break;
					}
					break;
				case 3:
					manager.ShowGoals();
					break;
				case 4:
					break;
				case 5:
					break;
				case 6:
					go = false;
					break;
			}
		}
	}
}
