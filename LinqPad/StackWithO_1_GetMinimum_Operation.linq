<Query Kind="Program" />

void Main()
{
	var stack = new MinStack();
	stack.Push(2);
	stack.Push(6);
	stack.Push(4);
	stack.GetMinimum().Dump();
	stack.Push(1);
	stack.Push(5);
	stack.GetMinimum().Dump();
	stack.Pop();
	stack.Pop();
	stack.GetMinimum().Dump();
	stack.Pop();
	stack.Pop();
	stack.GetMinimum().Dump();
	stack.Pop();
	stack.GetMinimum().Dump();
}

// Define other methods and classes here
public class MinStack{
	private Stack minStack{get;set;}
	private Stack RegularStack{get;set;}
	private int minValue = int.MaxValue;
	public MinStack(){
		minStack = new Stack();
		RegularStack = new Stack();
	}
	
	public void Push(int input){
		RegularStack.Push(input);
		if (input < minValue)
		{
			minValue = input;
		}
		minStack.Push(minValue);
	}
	public object Pop(){
		minStack.Pop();
		return RegularStack.Pop();
	}
	public object GetMinimum(){
		if (minStack.Count == 0)
		{
			return -1;
		}
		return minStack.Peek();
	}
}