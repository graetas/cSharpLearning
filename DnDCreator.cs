// dnd character maker

using System;
using System.IO.TextWriter;

public class DnDCreator
{
	public static void Main()
	{
		Console.WriteLine("Welcome to the DnD Character Generator!");

		// stats
		Random rand = new Random();
		string[] StatTitles = {	"Strength", "Dexterity", "Constitution", 
								"Intelligence", "Wisdom", "Charisma"};
		int[] Statistics = new int[6];
		SetStats(ref Statistics);
		int[] Modifiers = new int[6];
		Statistics.CopyTo(Modifiers, 0);
		Modifier(ref Modifiers);
		
		for(int i = 0; i < 6; i++)
		{
			Console.WriteLine("\t{0}: \t{1} \t({2})", StatTitles[i], Statistics[i], Modifiers[i]);
		}	

		System.IO.StreamWriter file =
   			new System.IO.StreamWriter("test.txt", true);

		Console.Read();
	}

	public static void Modifier(ref int[] mod)
	{
		for(int i = 0; i < 6; i++)
		{
			double x = mod[i];
			if(x >= 10)
				mod[i] = (int)Math.Ceiling((x - 10)/2.0);
			else
				mod[i] = (int)Math.Floor((x - 10)/2.0);
		}
	}





	public static void SetStats(ref int[] stat)
	{
		int sum = 0;
		int x = 0;
		Random rand = new Random();

		for(int i = 0; i < 6; i++)
		{
			x = rand.Next(8, 16);
			stat[i] = x;
			sum += x;
		}

		if(sum > 70)
		{
			for(int i = 0; i < (sum - 70); i++)
			{
				x = rand.Next(1, 6);
				int y = stat[x];
				stat[x] = y - 1;
			}
		} 
		else if(sum < 70)
		{
			for(int i = 0; i < (70 - sum); i++)
			{
				x = rand.Next(1, 6);
				int y = stat[x];
				stat[x] = y + 1;
			}
		}
	}
}