namespace UnitTest
{
    public class StringCalculator_Should
    {
        private StringCalculator _stringCalculator=new StringCalculator();
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
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("1,3", 4)]
        public void Return_Sum_Numbers_With_Two_Numbers(string numbers, int expected)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        public void Return_Sum_Numbers_With_Three_Numbers(string numbers, int expected)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        public void Return_Sum_Numbers_With_Two_Numbers_With_New_Lines_In_Input(string numbers, int expected)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(";\n1;2", 3)]
        public void Return_Sum_Numbers_With_Two_Numbers_With_Different_Delimiters(string numbers, int expected)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }
    }

    
}