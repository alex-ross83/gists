<Query Kind="Program" />

void Main()
{
	var input = new int[]{1,-2,3,10,-4,7,2,-5};
	var max_sum = FindMaxSum(input);
	max_sum.Dump();
}

// Define other methods and classes here

int FindMaxSum(int[] input){
	var max_sum = 0;
	var curr_sum = 0;
	for (int i = 0; i < input.Length; i++)
	{
		if (curr_sum <= 0)
		{
			curr_sum = input[i];
		}
		else
		{
			curr_sum += input[i];
		}
		if (curr_sum > max_sum)
		{
			max_sum = curr_sum;
			max_sum.Dump();
		}
		
	}
	return max_sum;
}