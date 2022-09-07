using System;

public class DogListDisplayer
{
	public DogListDisplayer()
	{
		List<int> doglist = new List<int>
		{ 1, 2, 3, 4, 5, 6,};

		Console.WriteLine(doglist);
		Console.ReadKey();
	}
}
