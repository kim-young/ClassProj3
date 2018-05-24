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
			if (Console.ReadLine() != null)
			{
				int numberTwo = int.Parse(Console.ReadLine());
				Console.WriteLine(Calculation.MathOperation(numberOne, numberTwo));
			}

			else
			{
				int numberTwo = 0;
				Console.WriteLine(Calculation.MathOperation(numberOne, numberTwo));            
			}
        }
    }
}
