public class Activity{
	protected string _name;
	protected string _description;
	protected int _duration;

	public void DisplayStartingMessage(){
		Console.Clear();
		Console.WriteLine($"Welcome to the {_name}.\n{_description}\n");
		Console.Write("Activity length, seconds: ");
		_duration = int.Parse(Console.ReadLine());
		Console.Clear();
		Console.WriteLine("Prepare to begin!");
		Spinner(3);
		Console.WriteLine();
	}

	public void DisplayEndingMessage(){
		Console.WriteLine($"Done! Good job!");
		Spinner(3);
		Console.WriteLine($"\nYou did the {_name} for {_duration} seconds.");
	}

	public void Spinner(double time = 3.0){
		List<char> chars = new List<char>{'|', '/', '-', '\\'};
		for (double i = 0.0; i < time; i += .25){
			Console.Write($"\b{chars[(int)(i * 4) % 4]}");
			Thread.Sleep(250);
			Console.Write("\b \b");
		}
	}
}
