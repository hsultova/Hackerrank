using System;

class Solution
{
	static void Main(String[] args)
	{
		string time = Console.ReadLine();
		int hours = int.Parse(time.Split(':')[0]);
		string timeWithoutHours = time.Split(':')[1] + ":" + time.Split(':')[2];
		string convertedTime = "";
		if (time.Contains("PM"))
		{
			if (hours != 12)
			{
				hours += 12;
			}
			convertedTime = hours + ":" + timeWithoutHours.Split('P')[0];
		}
		else
		{
			if (hours == 12)
			{
				convertedTime = "00:" + timeWithoutHours.Split('A')[0];
			}
			else
			{
				convertedTime = time.Split('A')[0];
			}
		}
		Console.WriteLine(convertedTime);
	}
}
