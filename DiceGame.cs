// Dice game

using System;

public class DiceGame
{
	public static void Main()
	{
		string p1 = null;
		string p2 = null;

		int p1Score = 0;
		int p2Score = 0;
		
		StartGame(ref p1, ref p2);
		Random r = new Random();

		while(p1Score < 100 && p2Score < 100)
		{
			p1Score += PlayGame(p1, r);
			p2Score += PlayGame(p2, r);
		}
		
		if(p1Score >= 100)
			Console.WriteLine("{0} Wins!", p1);
		else
			Console.WriteLine("{0} Wins!", p2);
		
		Console.WriteLine("{0}: {1} \t {2}: {3}", p1, p1Score, p2, p2Score);
	}

	public static int RollDice(Random r)
	{
		int n = r.Next(1, 10000)% 6 + 1;
		return n;
	}

	public static void StartGame(ref string p1, ref string p2)
	{
		Console.WriteLine("Welcome to the Dice Game!");
		Console.Write("Enter Player 1 name: ");
		p1 = Console.ReadLine();
		Console.Write("Enter Player 2 name: ");
		p2 = Console.ReadLine();
		Console.WriteLine("Let's Begin!");
	}

	public static int PlayGame(string Player, Random r)
	{
		Console.Write("{0} throws: \t", Player);
		ConsoleKeyInfo key = Console.ReadKey();
		int Score = 0;
		do
		{
			if(key.Key == ConsoleKey.Spacebar){
				int roll = RollDice(r);
				if(roll == 1){
					Score = 0;
					Console.Write("(bust, +{0}) \n", Score);
					return Score;
				}

				Score += roll; 
				Console.Write("{0}", roll);
			}
			key = Console.ReadKey();
		} while(key.Key != ConsoleKey.Escape);

		Console.Write("\t(stops, +{0})\n", Score);
		return Score;
	} 
}