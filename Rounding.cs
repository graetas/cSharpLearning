// rounding

using System;

public class Rounding
{
	public static void Main()
	{
		Console.WriteLine("Enter your numbers to be divided: ");
		int count = Int32.Parse(Console.ReadLine());

		double[] roundArr = new double[count];
		string nums;

		for(int i = 0; i < count; i++)
		{
			nums = Console.ReadLine();
			string[] split = nums.Split(' ');

			double mid = Double.Parse(split[0])/Double.Parse(split[1]);
			double final = 0;

			if(mid >= 0)
			{
				if(mid%1 >= 0.5)
					final = Math.Ceiling(mid);
				else
					final = Math.Floor(mid);
			}
			else if(mid < 0)
			{
				if(mid%(-1) <= 0.5)
					final = Math.Ceiling(mid);
				else
					final = Math.Floor(mid);
			}

			roundArr[i] = final;

		}

		foreach(double num in roundArr)
		{
			Console.Write("Answer: {0} ", num);
		}
		Console.Read();
	}
}