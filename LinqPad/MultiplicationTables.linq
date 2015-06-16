<Query Kind="Program" />

void Main()
{
	MultiplicationTable(12);
}

// Define other methods and classes here
public static void MultiplicationTable(int factor){
	for (int i = 1; i <= factor; i++)
	{
		for (int j = 1; j <= factor; j++)
		{
			Console.Write("{0}\t", i*j);
		}
		Console.WriteLine();
	}
}