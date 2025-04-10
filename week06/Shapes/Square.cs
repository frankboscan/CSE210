public class Square : Shape{
	private double _side;

	public void SetSide(double side){
		_side = side;
	}

	public override float GetArea(){
		return _side * _side;
	}
}
