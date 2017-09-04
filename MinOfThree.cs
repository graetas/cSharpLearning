// minimum of three

using System;

public class MinOfThree
{
	public static void Main()
	{
		Console.WriteLine("Enter your numbers find the minimum: ");
		string count = Console.ReadLine();
		int counter = Int32.Parse(count);

		int[] minArr = new int[counter];
		string nums = null;
		
		for(int i = 0; i < counter; i++)
		{
			nums = Console.ReadLine();
			string[] split = nums.Split(' ');

			if(Int32.Parse(split[0]) < Int32.Parse(split[1]))
			{
				if(Int32.Parse(split[0]) < Int32.Parse(split[2]))
					minArr[i] = Int32.Parse(split[0]);

				else if(Int32.Parse(split[2]) < Int32.Parse(split[0]))
					minArr[i] = Int32.Parse(split[2]);
			}
			else //if (Int32.Parse(split[1]) < Int32.Parse(split[0]))
			{
				if(Int32.Parse(split[1]) < Int32.Parse(split[2]))
					minArr[i] = Int32.Parse(split[1]);

				else if(Int32.Parse(split[2]) < Int32.Parse(split[1]))
					minArr[i] = Int32.Parse(split[2]);
			}
				
		}

		foreach(int min in minArr)
		{
			Console.Write("{0} ", min);
		}

		Console.Read();
	}
}