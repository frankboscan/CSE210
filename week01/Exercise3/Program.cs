using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
	int randomInt = randomGenerator.Next(1,101);
	Console.WriteLine("Guess the number: ");
	int guess = int.Parse(Console.ReadLine());
	while (guess != randomInt) {
		if (guess > randomInt) {
			Console.Write("Too high. Try again: ");
		} else {
			Console.Write("Too low. Try again: ");
		}
		guess = int.Parse(Console.ReadLine());
	}
	Console.WriteLine("You got it!");
    }
}
