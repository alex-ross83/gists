<Query Kind="Program" />

void Main()
{
	for(int i = 0; i < 10; i++)
	{
		CalculateNthFibonacci(i).Dump();
	}
}

// Define other methods and classes here
int CalculateNthFibonacci(int n){
	if (n <= 1)
	{
		return n;
	}
	return CalculateNthFibonacci(n-1) + CalculateNthFibonacci(n-2);
}