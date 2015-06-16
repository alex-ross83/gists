<Query Kind="Program" />

void Main()
{
	for (int i = 0; i < 100; i++)
	{
		Console.Write("{0}\t",i%2 == 1? i.ToString(): string.Empty);
	}
}
