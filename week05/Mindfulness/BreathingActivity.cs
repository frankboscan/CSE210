public class BreathingActivity : Activity{
	public BreathingActivity(){
		_name = "Breathing Activity";
		_description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
		_duration = 0;
	}

        public void Breathe(int time = 3){
                for (int i = 0; i < time; i++){
                        Thread.Sleep(1000);
                        Console.WriteLine();
			if (i % 4 == 0 && time != 3)
				Console.WriteLine("Breath in...");
			if (i % 4 == 2 && time != 3)
				Console.WriteLine("Breath out...");
                }
                Console.WriteLine();
        }

	public void Run(){
		DisplayStartingMessage();
		Breathe(_duration);
		DisplayEndingMessage();
	}
}	
