public class Verses{
	private List<Word> _words = new List<Word>();
	
	public Verses(string verses){
		foreach (string word in verses.Split())
			_words.Add(new Word(word));
	}

	public void Display(){
		Console.WriteLine(string.Join(" ", _words.Select(w => w.GetWord())));
	}

	public int GetWordCount(){
		return _words.Count;
	}

	public void HideWord(int fadeCount){
		_words[fadeCount].Hide();
	}
}
