using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var n = int.Parse(Console.ReadLine());
	var phonebook = new Dictionary<string, long>();
	for (int i = 0; i < n; i++)
	{
		var line = Console.ReadLine().Split(' ');
		phonebook.Add(line[0], long.Parse(line[1]));
	}
	for (int i = 0; i < n; i++)
	{
		var line = Console.ReadLine();
		if (phonebook.ContainsKey(line))
		{
			Console.WriteLine(line + '=' + phonebook[line]);
		}
		else
		{ 
			Console.WriteLine("Not found");
		}
	}
    }
}
