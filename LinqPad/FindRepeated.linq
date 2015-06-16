<Query Kind="Program" />

void Main()
{
	var input = new int[]{1, 2, 3, 1, 3, 6, 6, 2, 9, 9};
	Console.WriteLine("The repeating numbers are: ");
	FindDuplicates(input);
}

// Define other methods and classes here

void FindDuplicates(int[] input){
	for (int i = 0; i < input.Length; i++)
	{
		if (input[Math.Abs(input[i])] > 0)
		{
			input[Math.Abs(input[i])] = input[Math.Abs(input[i])] * -1;
		}
		else
		{
			Console.WriteLine(Math.Abs(input[i]));
		}
	}
}