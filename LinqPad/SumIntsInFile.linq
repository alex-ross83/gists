<Query Kind="Program" />

void Main()
{
	SumIntsFromFile(@"c:/SumInts.txt");
}

// Define other methods and classes here
static void SumIntsFromFile(string fullFileName){
	var text = File.ReadAllLines(fullFileName);
	int current = 0;
	int sum = 0;
	for (int i = 0; i < text.Length; i++)
	{
		if (text[i] == null || text[i] == "")
		{
			continue;
		}
		current = int.Parse(text[i]);
		sum += current;
		Console.WriteLine("Current Line Input:{0}\tCurrent Sum:{1}", current,sum);
	}
}