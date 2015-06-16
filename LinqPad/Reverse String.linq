<Query Kind="Program" />

void Main()
{
	ReverseString("Anita lava la tina").Dump();
}

// Define other methods and classes here
string ReverseString(string input){
	if(input == null || input.Length < 1)
		return "";
	char[] chars = input.ToCharArray();
	char temp;
	int lastIx = chars.Length - 1;
	for (int i = 0; i < chars.Length/2; i++)
	{
		temp = chars[lastIx - i];
		chars[lastIx - i] = chars[i];
		chars[i] = temp;
	}
	return new string(chars);
}