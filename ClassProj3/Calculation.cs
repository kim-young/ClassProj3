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

        public static int MathOperation(int numberOne, int numberTwo = 10)
		{
			int result = numberOne + numberTwo;
			return result;
		}
    }
}
