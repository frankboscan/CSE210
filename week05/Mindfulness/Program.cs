/* Reflecting Activity: does not duplicate random questions. */

using System;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Menu options:");
	Console.WriteLine("\t1. Breathing\n\t2. Reflection\n\t3. Listing\n\t4. Quit");
        Console.WriteLine("Select a choice from the menu:");
	switch (int.Parse(Console.ReadLine())){
		case 1:
			BreathingActivity breathing = new BreathingActivity();
			breathing.Run();
			break;
                case 2:
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Run();
                        break;
		case 3:
			ListingActivity listing = new ListingActivity();
			listing.Run();
			break;
		case 4:
			break;
		default:
			Console.WriteLine("Invalid option.");
			break;
	}
    }
}
