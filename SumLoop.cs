// sum loop

using System;

public class SumLoop
{
	public static void Main()
	{
		Console.WriteLine("Enter your numbers to be summed: ");
		
		string num1 = Console.ReadLine();
		string nums = Console.ReadLine();
		//string nums = num2;
		/* while(!string.IsNullOrWhiteSpace(num = Console.ReadLine()))	
		{
			num = num + " ";
			nums = nums + num;
		}
		
		*/
		string[] split = nums.Split(' ');

		int sum = 0;

		foreach(string input in split)
		{
			sum = sum + Int32.Parse(input);
		}

		Console.WriteLine("Sum: {0}", sum);
		Console.Read();
	}
}