// Stretch: randomly hides only visible words
// Stretch (not really): encourages users to learn Croatian

class Program{
	static void Main(string[] args){
		Reference reference = new Reference("1 Nefi", 3, 7, 8);
		Verses verses = new Verses("I dogodi se da ja, Nefi, rekoh ocu svome: Poći ću i učiniti ono što Gospod zapovjedi, jer znadem da Gospod ne daje zapovijedi djeci ljudskoj, osim ako ne pripravi put za njih da mogu izvršiti ono što im zapovjedi. I dogodi se, kad otac moj ču te riječi, bijaše silno radostan, jer spozna da Gospod mene blagoslovi.");
		Scripture scripture = new Scripture(reference, verses);
		Console.Clear();
		scripture.Display();
		Console.WriteLine("\nPress ENTER to continue, or \"quit\" to exit.");
		string choice = Console.ReadLine();

                List<int> ranks = new List<int>();
                List<int> randomRanks = new List<int>();
                Random random = new Random();
                for (int i = 0; i < verses.GetWordCount(); i++)
                        ranks.Add(i);
                for (int i = 0; i < verses.GetWordCount(); i++){
			int index = random.Next(0, ranks.Count);
			int value = ranks[index];
			ranks.RemoveAt(index);
			randomRanks.Add(value);
		}
		int fadeCount = 0;

		while (choice != "quit"){
			Console.Clear();

			for (int i = 0;
				i < 5 && fadeCount < verses.GetWordCount();
				i++, fadeCount++)
				scripture.HideWord(randomRanks[fadeCount]);
			scripture.Display();
			if (fadeCount  == verses.GetWordCount())
				Console.WriteLine("\nYou did it! \"quit\" to exit.");
			else
				Console.Write("ENTER to continue, or \"quit\".\n");
			choice = Console.ReadLine();
		}

	}
}
