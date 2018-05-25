using System;

namespace ClassProj3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input first number.");
			int numberOne = int.Parse(Console.ReadLine());
            
			Console.WriteLine("Input second number. (optional)");
			string numberTwo = Console.ReadLine();

			if (numberTwo.Length == 0)
			{
				Console.WriteLine(Calculation.MathOperation(numberOne));
			}

			else
   			{
				Console.WriteLine(Calculation.MathOperation(numberOne, int.Parse(numberTwo)));
			}
		}
    }
}
