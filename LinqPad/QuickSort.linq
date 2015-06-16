<Query Kind="Program" />

void Main()
{
	int[] input = new int[]{8,7,9,6,5,4,1,2,5,6,3,2,5,8,9,6};
	input.PrintArray();
	Console.WriteLine();
	
	QuickSort(input, 0, input.Length - 1);
	input.Dump();
	
}

// Define other methods and classes here

void QuickSort(int[] input, int left, int right)
{
	int i = left, j = right;
	var pivotIndex = i+j/2;
	var pivotValue = input[pivotIndex];
	while(i <= j){
		while(input[i] < pivotValue){
			i++;
		}
		while(input[j] > pivotValue){
			j--;
		}
		if (i <= j)
		{
			var tmp = input[i];
			input[i]=input[j];
			input[j]=tmp;
			
			i++;
			j--;
		}
	}
	Console.WriteLine("Iteration");
	input.PrintArray();
	if (left < j)
	{
		QuickSort(input, left, j);
	}
	if (i < right)
	{
		QuickSort(input, i, right);
	}
	
}

public static class ExtensionMethods
{

	public static void PrintArray(this int[] arr){
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write(arr[i] + " ");
		}
		Console.WriteLine();
	}
}