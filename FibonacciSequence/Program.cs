using System;

namespace FibonacciSequence
{
	class Program
	{
		static void Main(string[] args)
		{
			int iFirst = 0;
			int iSecond = 1;
			int[] MainArray = new int[10];

			MainArray[0] = iFirst;
			MainArray[1] = iSecond;

			for(int CurrentNumber = 2; CurrentNumber <= 9; CurrentNumber++)
			{
				MainArray[CurrentNumber] = iFirst + iSecond;
				iFirst = iSecond;
				iSecond = MainArray[CurrentNumber];
			}

			foreach(int number in MainArray)
			{
				Console.Write($"{number}");
				Console.Write(",");
			}
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
