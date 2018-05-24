using System;
namespace ClassProj3
{
    public class Calculation
    {
        public Calculation()
        {
        }

  //      public static int MathOperation(int numberOne)
		//{
		//	int result = numberOne + 100;
		//	return result;        
		//}

        public static int MathOperation(int numberOne, params int[] numberTwo)
		{
			int result = numberOne;

			if (numberTwo != null)
			{
				foreach (var i in numberTwo)
				{
					result += i;
				}
			}         
			return result;
		}
    }
}
