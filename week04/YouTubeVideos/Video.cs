public class Video{
	private string _title;
	private string _author;
	private int _length;
	private List<Comment> comments = new List<Comment>();
	
	public Video(string title, string author, int length){
		_title = title;
		_author = author;
		_length = length;
	}

	public void SetTitle(string title){
		_title = title;
	}

	public void SetAuthor(string author){
		_author = author;
	}

	public void SetLength(int length){
		_length = length;
	}

	public int GetNumberComments(){
		return comments.Count;
	}

	public void AddComment(string name, string text){
		Comment comment = new Comment(name, text);
		comments.Add(comment);
	}

	public void Display(){
		Console.WriteLine($"\n{_title}, {_author}, {_length} sec.");
		Console.WriteLine($"{comments.Count} comments:\n");
		foreach (Comment c in comments)
			c.Display();
	}
}
