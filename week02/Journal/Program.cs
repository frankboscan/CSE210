// I used a switch in order to manage menu input, rather than
// a bunch of if statements (lines 19 - 26).

using System;

class Program {
	static void Main(string[] args){
		Journal journal = new Journal();
		int choice = 0;
		while (choice != 5){
			Console.WriteLine(@$"
Please select one of the following:
1. Write
2. Display
3. Load
4. Save
5. Quit");
			choice = int.Parse(Console.ReadLine());
			switch (choice) {
				case 1: journal.Write(); break;
				case 2: journal.Display(); break;
				case 3: journal.Load(); break;
				case 4: journal.Save(); break;
				case 5: break;
				default: Console.WriteLine("Try again: "); break;
			}
		};
	}
}
