<Query Kind="Program" />

void Main()
{
	//var input = new int[]{100,500,350,450,600,500,700,200,900,600};
	var input = new int[]{600,500,400,300,200,100,0};
	var bestProfit = CalculateBestProfit(input);
	bestProfit.Dump();
}
// Define other methods and classes here

int CalculateBestProfit(int[] stock_prices_yesterday)
{
	var maxProfit = 0;
	var lowestBuy = stock_prices_yesterday[1] - stock_prices_yesterday[0];
	for (int i = 0; i < stock_prices_yesterday.Length; i++)
	{
		if (stock_prices_yesterday[i] < lowestBuy)
		{
			lowestBuy = stock_prices_yesterday[i];
		}
		if ((stock_prices_yesterday[i] - lowestBuy) > maxProfit)
		{
			maxProfit = stock_prices_yesterday[i] - lowestBuy;
		}
	}
	return maxProfit;
}
