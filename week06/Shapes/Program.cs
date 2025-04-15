using System;

class Program{
	static void Main(string[] args){
		List<Shape> shapes = new List<Shape>();
		shapes.Add(new Square("blue", 2));
                shapes.Add(new Rectangle("red", 2, 3));
                shapes.Add(new Circle("yellow", 2));
                for (int i = 0; i < shapes.Count; i++)
			Console.WriteLine(shapes[i].GetColor() + shapes[i].GetArea());
	}
}
