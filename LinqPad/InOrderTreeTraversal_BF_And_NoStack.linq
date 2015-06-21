<Query Kind="Program" />

void Main()
{
	var root = new Node(){Value=1,
			Left = new Node(){ Value=2,
				Left=new Node(){Value=4},
				Right=new Node(){Value=5}},
				Right=new Node(){Value=3}};
	"Original Tree:".Dump();
	root.PrintTreeBF();
	"Morris Tree:".Dump();
	MorrisTraversal(root);
	
}

private void MorrisTraversal(Node node){
	Node pre = null;
	Node current = node;
	while (current!=null)
	{
		if (current.Left == null) //finished transforming the tree, return to original position
		{ 
			current.Value.Dump();
			current = current.Right;
		}
		else
		{
			pre = current.Left;
			while (pre.Right != null)
			{
				pre = pre.Right;
			}
			pre.Right = current;
			Node temp = current;
			current = current.Left;
			temp.Left=null;
		}	
	}
	
}

// Define other methods and classes here
public static class ExtensionMethods
	{
	
	public static void PrintTreeBF(this Node root)
	{
		var queue = new Queue<Node>();
		queue.Enqueue(root);
		while (queue.Count()> 0)
		{
			var current = queue.Dequeue();
			current.Value.Dump();
			if (current.Left!=null)
			{
				queue.Enqueue(current.Left);
			}
			if (current.Right != null)
			{
				queue.Enqueue(current.Right);
			}
		}
	}
}

public class Node{
	public Node Left { get; set; }
	public Node Right { get; set; }
	public int Value { get; set; }
}