using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your percentage grade (e.g. for 90%, write \"90\")? ");
	int percentGrade = int.Parse(Console.ReadLine());
	string letterGrade;

	if (percentGrade >= 90) {
		letterGrade = "A";
	}
	else if (percentGrade >= 80) {
		letterGrade = "B";
	}
	else if (percentGrade >= 70) {
		letterGrade = "C";
	}
	else if (percentGrade >= 60) {
		letterGrade = "D";
	}
	else {
		letterGrade = "F";
	}

	Console.WriteLine($"Your letter grade: {letterGrade}");

	if (percentGrade >= 70) {
		Console.WriteLine("Congratulations, you passed!");
	}
	else {
		Console.WriteLine("Good effort, but not quite. Try again next time!");
	}
    }
}
