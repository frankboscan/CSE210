public class ReflectingActivity : Activity{
	public ReflectingActivity(){
		_name = "Reflecting Activity";
		_description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
		_duration = 0;
	}

	public void Run(){
		DisplayStartingMessage();
		DisplayRandomPrompt();
		DisplayRandomQuestions();
		DisplayEndingMessage();
	}

	public void DisplayRandomPrompt(){
		List<string> prompts = new List<string>{
			"Think of a time when you stood up for someone else.",
			"Think of a time when you did something really difficult.",
			"Think of a time when you helped someone in need.",
			"Think of a time when you did something truly selfless.",
		};
		Random random = new Random();
		Console.WriteLine(prompts[random.Next(0, prompts.Count)]);
	}

        public void DisplayRandomQuestions(){
                List<string> questions = new List<string>{
			"Why was this experience meaningful to you?",
			"Have you ever done anything like this before?",
			"How did you get started?",
			"How did you feel when it was complete?",
			"What made this time different than other times when you were not as successful?",
			"What is your favorite thing about this experience?",
			"What could you learn from this experience that applies to other situations?",
			"What did you learn about yourself through this experience?",
			"How can you keep this experience in mind in the future?",
		};
		Random random = new Random();
		List<int> indeces = new List<int>();
		List<int> randomIndeces = new List<int>();
		for (int i = 0; i < questions.Count; i++)
			indeces.Add(i);
		for (int i = 0; i < questions.Count; i++){
			int a = random.Next(0, indeces.Count);
			indeces.RemoveAt(a);
			randomIndeces.Add(a);
		}
		Console.Clear();
		for (int i = 0; i < _duration && i < 90; i += 10){
			Console.WriteLine("\n" + questions[randomIndeces[i / 10]]);
			Spinner(10);
			Console.WriteLine("\b");
		}
	}
}
