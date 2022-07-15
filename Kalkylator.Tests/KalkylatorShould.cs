namespace Kalkylator.Tests
{
    public class KalkylatorShould
    {
        [Fact]
        public void AdditionWithTwoNumbers()
        {
            //Arrange 
            double a = 2.8, b = 1.2;

            //Act
            var sut = Operations.Addition(a, b);

            //Assert
            Assert.Equal(a + b, sut);
        }

        [Fact]
        public void SubtractionWithTwoNumbers()
        {
            //Arrange 
            double a = 5.8, b = 5.2;

            //Act
            var sut = Operations.Subtraction(a, b);

            //Assert
            Assert.Equal(a - b, sut);
        }

        [Fact]
        public void MultiplicationWithTwoNumbers()
        {
            //Arrange 
            double a = 3.8, b = 3.2;

            //Act
            var sut = Operations.Multiplication(a, b);

            //Assert
            Assert.Equal(a * b, sut);
        }

        [Fact]
        public void DivisionWithTwoNumbers()
        {
            //Arrange 
            double a = 4.8, b = 4.2;

            //Act
            var sut = Operations.Division(a, b);

            //Assert
            Assert.Equal(a / b, sut);
        }

        [Fact]
        public void DivisionWithZero()
        {
            //Arrange 
            double a = 5.8, b = 0;

            //Act
            var sut = Operations.Division(a, b);

            //Assert
            Assert.Equal(a / b, sut);
        }

        [Fact]
        public void AdditionWithMultipleNumbers()
        {
            //Arrange 

            double[] doubleArray = new double[] { 10, 20, 30, 40, 50 };

            //Act
            var sut = Operations.Addition(doubleArray);

            //Assert
            Assert.Equal(150, sut);
        }

        [Fact]
        public void SubtractionWithMultipleNumbers()
        {
            //Arrange 

            double[] doubleArray = new double[] { 10, 20, 30, 40, 45 };

            //Act
            var sut = Operations.Subtraction(doubleArray);

            //Assert
            Assert.Equal(145, sut);
        }

        [Fact]
        public void InputIsNotANumber()
        {
            //Arrange 
            string a = "5,78";
            string b = "w";
            bool test = Double.TryParse(a, out double result);
            bool test2 = Double.TryParse(b, out double result2);
            //Act

            //Assert
            Assert.True(test);
            Assert.False(test2);
        }
    }
}