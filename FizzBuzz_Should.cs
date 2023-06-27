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

        [Theory]
        [InlineData("1", true)]
        [InlineData("100", true)]
        [InlineData("50", true)]
        [InlineData("101", false)]
        [InlineData("-1", false)]
        public void Return_Is_Number_In_Range(string number, bool expected)
        {
            var result = _fizzBuzz.IsWithinRange(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-1", "Number is out of range")]
        [InlineData("-100", "Number is out of range")]
        public void Return_Throw(string number, string expected)
        {
            Action action = () => _fizzBuzz.PrintIfNumberInRange(number);

            var ex = Assert.Throws<Exception>(action);
            Assert.Equal(expected, ex.Message);
        }

        [Theory]
        [InlineData("1", "1")]
        [InlineData("2", "2")]
        [InlineData("3", "fizz")]
        [InlineData("6", "fizz")]
        [InlineData("10", "buzz")]
        [InlineData("20", "buzz")]
        [InlineData("15", "fizzbuzz")]
        [InlineData("30", "fizzbuzz")]
        public void Return_As_Expected(string number, string expected)
        {
            var result = _fizzBuzz.PrintIfNumberInRange(number);

            Assert.Equal(expected, result);
        }
    }
}