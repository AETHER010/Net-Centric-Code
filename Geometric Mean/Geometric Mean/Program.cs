using System;

namespace Geometric_mean
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Geometric Mean Calculation\n");
			int[] data = { 5, 15, 25, 30, 45 };
			int value = 1;
			for (int i = 0; i < data.Length; i++)
			{
				value = value * data[i];
			}
			double result = Math.Pow(value, 1.0 / data.Length);

			Console.WriteLine($"Geometric Mean = {result}");

		}
	}
}

