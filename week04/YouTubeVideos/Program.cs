using System;

class Program{
	static void Main(string[] args){
		Video dogs = new Video("Dogs", "Jimmy", 17);
		dogs.AddComment("Phil", "Great!");
		dogs.AddComment("Ross", "Wow!");
		dogs.AddComment("Jerry", "Awesome!");

		Video cats = new Video("Cats", "Billy", 18);
                cats.AddComment("Felipe", "Great!");
                cats.AddComment("Roberto", "Wow!");
                cats.AddComment("Geraldo", "Awesome!");

		Video birds = new Video("Birds", "Bobby", 19);
                birds.AddComment("Philip", "Great!");
                birds.AddComment("Roger", "Wow!");
                birds.AddComment("Jimbo", "Awesome!");
		birds.AddComment("Will", "Super!");

		List<Video> videos = new List<Video>();
		videos.Add(dogs);
		videos.Add(cats);
		videos.Add(birds);

		foreach (Video video in videos){
			video.Display();
		};
	}
}
