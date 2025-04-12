using System;

class Program{
	static void Main(string[] args){
		MathAssignment thursday = new MathAssignment(
			"Frank Boscan", "Trigonometry", "Unit Circle", "1-8b");
		Console.WriteLine(thursday.GetSummary());
		Console.WriteLine(thursday.GetHomeworkList());

		WritingAssignment friday = new WritingAssignment(
			"Frank Boscan", "Botany", "Invasive Flowers");
		Console.WriteLine(friday.GetSummary());
		Console.WriteLine(friday.GetWritingInformation());
	}
}
