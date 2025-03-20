/*
 * Class: Fraction
 *
 * Attributes:
 *  _numerator: int
 *  _denominator: int
 *
 * Methods:
 *  Fraction()
 *  Fraction(wholeNumber: int)
 *  Fraction(numerator: int, denominator: int)
 *  GetNumerator()
 *  SetNumerator(numerator: int)
 *  GetDenominator()
 *  SetDenominator(denominator: int)
 *  GetFractionString(): string
 *  GetDecimalValue(): double
 */

public class Fraction{
	private int _numerator, _denominator;

	public Fraction(){
		_numerator = _denominator = 1;
	}

	public Fraction(int wholeNumber){
		_numerator = wholeNumber;
		_denominator = 1;
	}

	public Fraction(int a, int b){
		_numerator = a;
		_denominator = b;
	}

	public int GetNumerator(){
		return _numerator;
	}

	public void SetNumerator(int a){
		_numerator = a;
	}

	public int GetDenominator(){
		return _denominator;
	}

	public void SetDenominator(int b){
		_denominator = b;
	}

	public string GetFractionString(){
		return $"{_numerator}/{_denominator}";
	}

	public double GetDecimalValue(){
		return (double)_numerator / _denominator;
	}
}
