using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[][] a = new int[n][];
		for (int a_i = 0; a_i < n; a_i++)
		{
			string[] a_temp = Console.ReadLine().Split(' ');
			a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
		}
		int sumDiagonal1 = 0;
		int sumDiagonal2 = 0;
		int row = 0;
		int col = 0;

		while (col < n && row < n)
		{
			sumDiagonal1 += a[row][col];
			row++;
			col++;
		}
		row = 0;
		col = n - 1;
		while (row < n && col >= 0)
		{
			sumDiagonal2 += a[row][col];
			row++;
			if (col != 0)
			{
				col--;
			}
		}
		Console.WriteLine(Math.Abs(sumDiagonal1 - sumDiagonal2));
	}
}

