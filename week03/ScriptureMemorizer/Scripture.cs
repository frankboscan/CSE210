public class Scripture{
	private Reference _reference;
	private Verses _verses;

	public Scripture(Reference reference, Verses verses){
		_reference = reference;
		_verses = verses;
	}

	public void Display(){
		_reference.Display();
		_verses.Display();
	}

	public void HideWord(int fadeCount){
		_verses.HideWord(fadeCount);
	}
}
