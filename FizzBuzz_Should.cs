namespace UnitTest
{
    public class FizzBuzz_Should
    {
        private FizzBuzz _fizzBuzz = new FizzBuzz();

        [Theory]
        [InlineData("1", "1")]
        [InlineData("2", "2")]
        public void Return_Number(string number, string expected)
        {
            var result = _fizzBuzz.Print(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("3", "fizz")]
        [InlineData("6", "fizz")]
        public void Return_Fizz(string number, string expected)
        {
            var result = _fizzBuzz.Print(number);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("10", "buzz")]
        [InlineData("20", "buzz")]
        public void Return_Buzz(string number, string expected)
        {
            var result = _fizzBuzz.Print(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("15", "fizzbuzz")]
        [InlineData("30", "fizzbuzz")]
        public void Return_Fizzbuzz(string number, string expected)
        {
            var result = _fizzBuzz.Print(number);

            Assert.Equal(expected, result);
        }
    }
}