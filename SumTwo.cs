// sum of two

using System;

public class Sum
{
	public static void Main()
	{
		Console.WriteLine("Enter your numbers to be summed: ");
		
		string nums = Console.ReadLine();

		string[] split = nums.Split(' ');

		int sum = 0;

		foreach(string num in split)
		{
			int number = Int32.Parse(num);
			sum = sum + number;
		}

		Console.WriteLine("Sum: {0}", sum);
		Console.Read();
	}
}