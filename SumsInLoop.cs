// sums in loop

using System;

public class SumsInLoop
{
	public static void Main()
	{
		Console.WriteLine("Enter your numbers to be summed: ");

		string count = Console.ReadLine();
		int counter = Int32.Parse(count);

		int[] sumArr = new int[counter];
		string nums = null;
		int sum = 0;

		for(int i = 0; i < counter; i++)
		{
			sum = 0;
			nums = Console.ReadLine();
			string[] split = nums.Split(' ');

			foreach(string input in split)
			{
				sum = sum + Int32.Parse(input);
			}

			sumArr[i] = sum;
			//Console.WriteLine("{0}", sum);
		}

		foreach(int mus in sumArr)
		{
			Console.Write("Sum: {0} ", mus);
		}
		Console.Read();
	}
}