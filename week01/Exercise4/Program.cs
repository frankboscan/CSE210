using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter a series of integers. Press \"0\" to stop:");
	List<int> ints = new List<int>();
	int entry;
	
	do {
		entry = int.Parse(Console.ReadLine());
		if (entry != 0) {
			ints.Add(entry);
		}
	} while (entry != 0);
	
	Console.Write("Your numbers: ");
	Console.WriteLine(string.Join(", ", ints));

	int sum = 0, max = -1;
	float mean;
	
	foreach (int i in ints) {
		sum += i;
		if (i > max) {
			max = i;
		}
	}

	mean = (float)sum / ints.Count;

	Console.WriteLine($"Sum = {sum}, max = {max}, mean = {mean}");
    }
}
