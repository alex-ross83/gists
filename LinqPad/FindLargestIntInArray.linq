<Query Kind="Program" />

void Main()
{
	var input = new int[]{1,4,56,9,8,7,4,6,3,2,14,4,56,9,74,2};
	LargestInt(input).Dump();
}

// Define other methods and classes here
static int LargestInt(int[] input)
{
	var max = 0;
	for (int i = 0; i < input.Length; i++)
	{
		if (input[i] > max)
		{
			max = input[i];
		}
	}
	return max;
}