/*
 * Class: Entry
 *
 * Attributes:
 *  _date : string
 *  _prompt : string
 *  _entry : string
 *
 * Methods:
 *  Display() : void
 *  AddDate() : void
 *  AddRandomPrompt : void
 *  AddEntry() : void
 */

public class Entry{
	public string _date = "", _prompt = "", _entry = "";
	public List<string> _prompts = new List<string>();

	public void Display(){
		Console.WriteLine(_date);
		Console.WriteLine(_prompt);
		Console.WriteLine(_entry);
	}

	public void AddDate(){
		Console.WriteLine("Date of entry: ");
		_date = Console.ReadLine();
	}

	public void AddRandomPrompt(){
		_prompts.Add("Most interesting person I interacted with today?");
		_prompts.Add("What was the best part of my day?");
		_prompts.Add("How did I see the hand of the Lord in my life today?");
		_prompts.Add("What was the strongest emotion I felt today?");
		_prompts.Add("What would I rather have done differently today?");
		_prompts.Add("What was the kindest thing I did to someone today?");
		Random random = new Random();
		_prompt = _prompts[random.Next(0, _prompts.Count)];
	}

	public void AddEntry(){
		Console.Write("> ");
		_entry = Console.ReadLine();
	}
}
