// triangles

using System;

public class Triangles
{
	public static void Main()
	{
		Console.WriteLine("Enter Triangle Edges: ");
		int count  = Int32.Parse(Console.ReadLine());

		int[] final = new int[count];

		for(int i = 0; i < count; i++)
		{
			string[] input = Console.ReadLine().Split(' ');

			int A = Int32.Parse(input[0]);
			int B = Int32.Parse(input[1]);
			int C = Int32.Parse(input[2]);

			if((A + B >= C) && (A + C >= B) && (B + C >= A))
				final[i] = 1;
			else 
				final[i] = 0;
		}

		foreach(int num in final)
		{
			Console.Write("Is valid? {0} ", num);
		}
		Console.Read();
	}
}