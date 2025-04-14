public class ListingActivity : Activity{
	public ListingActivity(){
                _name = "Listing Activity";
                _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                _duration = 0;
        }

	public void Countdown(int time = 3){
                for (int i = 0; i < time; i++){
                        Thread.Sleep(1000);
                        Console.Write($"\b{time - i - 1}");
                }
        }

        public void Run(){
                DisplayStartingMessage();
		DisplayRandomPrompt();
                Console.WriteLine("\nThink about the question for a few seconds.");
		Countdown(5);
		Console.WriteLine("\bList as many items as you can: ");
		List<string> answers = new List<string>();
		DateTime endTime = DateTime.Now.AddSeconds(_duration);
		while (DateTime.Now < endTime){
			Console.Write("> ");
			answers.Add(Console.ReadLine());
		}
		Console.WriteLine($"Well done: you listed {answers.Count} items.");
                DisplayEndingMessage();
        }

	public void DisplayRandomPrompt(){
		List<string> prompts = new List<string>{
			"Who are people that you appreciate?",
			"What are personal strengths of yours?",
			"Who are people that you have helped this week?",
			"When have you felt the Holy Ghost this month?",
			"Who are some of your personal heroes?"
		};
		Random random = new Random();
		Console.WriteLine(prompts[random.Next(0, prompts.Count)]);
	}

	
}
