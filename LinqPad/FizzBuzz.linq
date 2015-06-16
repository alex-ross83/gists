<Query Kind="Program" />

void Main()
{
	for (int i = 1; i <= 100; i++)
	{
		FizzBuzz(i);
	}
}

// Define other methods and classes here
void FizzBuzz(int input){
	if (input % 15 == 0)
	{
		Console.WriteLine("FizzBuzz");
		return;
	}
	if(input % 5 == 0)
	{
		Console.WriteLine("Buzz");
		return;
	}
	if (input % 3 == 0)
	{
		Console.WriteLine("Fizz");
		return;
	}
	Console.WriteLine(input);
}