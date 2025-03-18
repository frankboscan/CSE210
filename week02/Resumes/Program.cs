using System;

class Program{
    static void Main(string[] args){
        Job job1 = new Job();
	job1._company = "Google";
	job1._jobTitle = "Manager";
	job1._startYear = 2000;
	job1._endYear = 2002;

	Job job2 = new Job();
        job2._company = "Yahoo";
        job2._jobTitle = "General Manager";
        job2._startYear = 2002;
        job2._endYear = 2004;

	Resume myResume = new Resume();
	myResume._name = "Frank Boscan";
	myResume._jobs.Add(job1);
	myResume._jobs.Add(job2);
	myResume.Display();
    }
}
