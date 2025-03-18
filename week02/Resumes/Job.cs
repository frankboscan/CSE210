/* 
 * Class: Job
 *
 * Attributes:
 *  _company : string
 *  _jobTitle : string
 *  _startYear : int
 *  _endYear : int
 *
 * Behavior:
 *  Display() : void
 */

public class Job{
	public string _company = "";
	public string _jobTitle = "";
	public int _startYear = 0;
	public int _endYear = 0;

	public void Display(){
		Console.WriteLine(
				$"{_company}: {_jobTitle}, {_startYear}-{_endYear}"
				);
	}
}
