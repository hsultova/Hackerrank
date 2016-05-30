using System;
class Solution
{
	static void Main(String[] args)
	{
		int[][] arr = new int[6][];
		for (int arr_i = 0; arr_i < 6; arr_i++)
		{
			string[] arr_temp = Console.ReadLine().Split(' ');
			arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
		}
		int sum = 0;
		int maxSum = -63;
		for (int row = 0; row < 4; row++)
		{
			for (int col = 0; col < 4; col++)
			{
				sum += arr[row][col] + arr[row][col + 1] + arr[row][col + 2] + arr[row + 1][col + 1] + arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];
				if (sum > maxSum)
				{
					maxSum = sum;
				}
				sum = 0;
			}
		}
		Console.WriteLine(maxSum);
	}
}