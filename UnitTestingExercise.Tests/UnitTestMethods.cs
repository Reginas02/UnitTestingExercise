using System;

namespace UnitTestingExercise.Tests
{
    public class UnitTestMethods 
    {
        

        public UnitTestMethods()
        {

        }
        
            public int Add(int num1, int num2, int num3)
            {
                return num1 + num2 + num3;
            }

           public static int Subtract(int minuend, int subtrhend, int expected)
           {
            return minuend - subtrhend;
           }

            public int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }
            public int Divide(int num1, int num2)
            {
                return num1 / num2;
            }

        internal object Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }
    }
     
        
        

   
}





