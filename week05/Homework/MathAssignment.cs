public class MathAssignment : Assignment{
	private string _textbookSection;
	private string _problems;

	public string GetHomeworkList(){
		return $"{_textbookSection}, {_problems}";
	}
}
