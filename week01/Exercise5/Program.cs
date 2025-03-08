using System;

class Program {
	static void DisplayWelcome() {
		Console.WriteLine("Welcome to the Program!");
	}

	static string PromptUserName() {
		Console.Write("What is your name? ");
		return Console.ReadLine();
	}

	static int PromptUserNumber() {
		Console.Write("What is your favorite number? ");
		return int.Parse(Console.ReadLine());
	}

	static int SquareNumber(int n) {
		return n * n;
	}

	static void DisplayResult(string name, int number) {
		Console.WriteLine($"{name}, your favorite number squared is {number}");
	}

    	static void Main(string[] args) {
    		DisplayWelcome();
		string userName = PromptUserName();
		int userNumber = PromptUserNumber();
		userNumber = SquareNumber(userNumber);
		DisplayResult(userName, userNumber);		
    	}
}
