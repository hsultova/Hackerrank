using System;

class Solution
{
	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] arr_temp = Console.ReadLine().Split(' ');
		int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

		float positive = 0;
		float negative = 0;
		float zero = 0;

		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] > 0)
			{
				positive++;
			}
			else if (arr[i] < 0)
			{
				negative++;
			}
			else
			{
				zero++;
			}
		}
		Console.WriteLine(positive / n);
		Console.WriteLine(negative / n);
		Console.WriteLine(zero / n);
	}
}
