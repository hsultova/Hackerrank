using System;
class Solution
{
	static void Main(String[] args)
	{
		var n = int.Parse(Console.ReadLine());
		var strings = new string[n];
		for (int i = 0; i < n; i++)
		{
			strings[i] = Console.ReadLine();
		}
		var q = int.Parse(Console.ReadLine());
		var queries = new string[q];
		var counters = new int[q];
		for (int i = 0; i < q; i++)
		{
			queries[i] = Console.ReadLine();
		}

		for (int i = 0; i < q; i++)
		{
			for (int j = 0; j < n; j++)
			{
				if (queries[i] == strings[j])
				{
					counters[i]++;
				}
			}
		}

		foreach (int counter in counters)
		{
			Console.WriteLine(counter);
		}
	}
}