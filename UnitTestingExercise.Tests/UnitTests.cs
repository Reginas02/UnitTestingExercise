using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new UnitTestMethods();

            // create a Calculator object
            

            //Act
            var actual = test.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test1 = new UnitTestMethods();

            //Act
            var actual = test1.Subtract( minuend,  subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 10, 50)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 10, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
