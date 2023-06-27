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

        public void Return_1_When_String_Is_1(string numbers, int expected)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(numbers);

            Assert.Equal(expected, result);
        }
    }

    
}