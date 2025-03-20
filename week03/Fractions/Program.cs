using System;

class Program{
    	static void Main(string[] args){
        	Fraction fraction = new Fraction(2, 4);
		Console.WriteLine(fraction.GetDecimalValue());
		Console.WriteLine(fraction.GetFractionString());
		fraction.SetNumerator(7);
		fraction.SetDenominator(8);
		Console.WriteLine(fraction.GetNumerator());
		Console.WriteLine(fraction.GetDenominator());
    	}
}
