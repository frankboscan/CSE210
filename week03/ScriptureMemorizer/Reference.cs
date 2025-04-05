public class Reference{
	private string _book = "";
	private int _chapter, _startVerse, _endVerse = 0;

	public Reference(string book, int chapter, int verse){
		_book = book;
		_chapter = chapter;
		_startVerse = verse;
	}

	public Reference(string book, int chapter, int startVerse, int endVerse){
		_book = book;
		_chapter = chapter;
		_startVerse = startVerse;
		_endVerse = endVerse;
	}

	public void Display(){
		if (_endVerse == 0)
			Console.Write($"{_book} {_chapter}:{_startVerse}: ");
		else
			Console.Write($"{_book} " +
				$"{_chapter}:{_startVerse}-{_endVerse}: ");
	}
}
