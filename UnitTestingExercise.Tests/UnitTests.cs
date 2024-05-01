using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //DONE - Add test data <-------
        [InlineData(5, 5, 5, 15)]
        [InlineData(7, 6, 7, 20)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //DONE - Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();
            
            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            int actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 3, 4)] //Add test data <-------
        [InlineData(5, 10, -5)]
        [InlineData(5, 5, 0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //DONE - Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)] //Add test data <-------
        [InlineData(-5, 5, -25)]
        [InlineData(5, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //DONE - Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 1, 10)] //Add test data <-------
        [InlineData(0, 10, 0)]
        [InlineData(1, 10, 0)]
        [InlineData(10, -10, -1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
