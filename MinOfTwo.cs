// minimum of two

using System;

public class MinOfTwo
{
	public static void Main()
	{
		Console.WriteLine("Enter numbers to find the minumum: ");

		string count = Console.ReadLine();
		int counter = Int32.Parse(count);

		int[] minArr = new int[counter];
		string nums = null;
		
		for(int i = 0; i < counter; i++)
		{
			nums = Console.ReadLine();
			string[] split = nums.Split(' ');

			if(Int32.Parse(split[0]) < Int32.Parse(split[1]))
				minArr[i] = Int32.Parse(split[0]);
			else 
				minArr[i] = Int32.Parse(split[1]);

		}

		foreach(int min in minArr)
		{
			Console.Write("Minimum: {0} ", min);
		}

		Console.Read();
	}
}