/*
 * Class: Journal
 *
 * Attributes:
 *  _entries : List<_entry>
 *
 * Methods:
 *  Display() : void
 *  Write() : void
 *  Save() : void
 *  Load() : void
 */

using System.IO;

public class Journal{
	public List<Entry> _entries = new List<Entry>();

	public void Display(){
		foreach (Entry entry in _entries)
			entry.Display();
	}

	public void Write(){
		Entry entry = new Entry();
		entry.AddDate();
		entry.AddRandomPrompt();
		Console.WriteLine(entry._prompt);
		entry.AddEntry();
		_entries.Add(entry);
	}

	public void Save(){
		Console.WriteLine("Save as (file name): ");
		string f = Console.ReadLine();
		using (StreamWriter outputFile = new StreamWriter(f))
			foreach (Entry entry in _entries)
				outputFile.WriteLine(
					$"{entry._date}|{entry._prompt}|{entry._entry}");
	}

	public void Load(){
		Console.WriteLine("Load from (file name): ");
		string f = Console.ReadLine();
		string[] lines = System.IO.File.ReadAllLines(f);
		foreach (string line in lines){
			Entry entry = new Entry();
			string[] parts = line.Split("|");
			entry._date = parts[0];
			entry._prompt = parts[1];
			entry._entry = parts[2];
			_entries.Add(entry);
		}
	}
}
