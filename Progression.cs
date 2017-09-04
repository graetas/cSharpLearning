// arithmetic progression

using System;

public class Progression
{
	public static void Main()
	{
		Console.WriteLine("Write your Linear Progression: ");

		int count = Int32.Parse(Console.ReadLine());

		int[] final = new int[count];

		for(int i = 0; i < count; i++)
		{
			string[] input = Console.ReadLine().Split(' ');


			int A = Int32.Parse(input[0]);
			int B = Int32.Parse(input[1]);
			int N = Int32.Parse(input[2]);
			int sum = 0;

			for(int x = 0; x < N; x++)
			{
				sum = sum + (A + x*B);
			}

			final[i] = sum;

		}


		foreach(int num in final)
		{
			Console.Write("Final Answer: {0} ", num);
		}
		Console.Read();
	}
}