namespace UnitTest
{
    public class StringCalculator_Should
    {
        [Fact]
        public void Return_Zero_When_Empty_String()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2", 2)]
        public void Return_Number_With_One_Number(string numbers, int expected)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("1,3", 4)]
        public void Return_Sum_Numbers_With_Two_Numbers(string numbers, int expected)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(numbers);

            Assert.Equal(expected, result);
        }
    }

    
}