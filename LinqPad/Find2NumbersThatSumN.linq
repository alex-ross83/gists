<Query Kind="Program" />

void Main()
{
	var input = new int[]{1,2,4,7,11,15};
	var s = 15;
	Find2Numbers(input,s).Dump();
}

// Define other methods and classes here

int[] Find2Numbers(int[] input, int sum){
	var map = new Hashtable();
	int i = 0, j = input.Length - 1;
	int res1 = 0, res2 =0;
	while (i < j)
	{
		var curr_sum = input[i]+input[j];
		if (curr_sum ==sum)
		{
			res1=input[i];
			res2=input[j];
			break;
		}
		if (curr_sum > sum)
		{
			j--;
		}
		else
		{
			i++;
		}
	}
	return new int[]{res1,res2};
}