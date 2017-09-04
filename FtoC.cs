// Fahrenheit to Celcius

using System;

public class FtoC
{
	public static void Main()
	{
		Console.WriteLine("Enter Fahrenheit: ");
		string data = Console.ReadLine();
		string[] split = data.Split(' ');

		int count = Int32.Parse(split[0]);
		double[] CelsiusArr = new double[count];

		for(int i = 0; i < count; i++)
		{
			double Fahrenheit = Double.Parse(split[i + 1]);

			double Celsius = (Fahrenheit - 32)/(1.8);

			double final = Celsius;

			
			if(Celsius >= 0)
			{
				if(Celsius%1 >= 0.50)
					final = Math.Ceiling(Celsius);
				else
					final = Math.Floor(Celsius);
			}
			else
			{
				if(Celsius%(-1) >= -0.50)
					final = Math.Ceiling(Celsius);
				else
					final = Math.Floor(Celsius);
			}
			CelsiusArr[i] = final;
		}


		foreach (double c in CelsiusArr)
		{
			Console.Write("Celcius: {0} ", c);
		}
		Console.Read();
	}
}