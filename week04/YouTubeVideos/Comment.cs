public class Comment{
	private string _name;
	private string _comment;

	public Comment(string name, string comment){
		_name = name;
		_comment = comment;
	}
	
	public void SetName(string name){
		_name = name;
	}

	public void SetComment(string comment){
		_comment = comment;
	}

	public string GetName(){
                return _name;
        }

        public string GetComment(){
                return _comment;
        }

	public void Display(){
		Console.WriteLine($"{_name}\n{_comment}\n");
	}
}
