namespace UnitTest
{
    public class FizzBuzz_Should
    {
        private FizzBuzz _fizzBuzz = new FizzBuzz();

        [Theory]
        [InlineData("1", "1")]
        [InlineData("2", "2")]
        public void Return_Zero_When_Empty_String(string number, string expected)
        {
            var result = _fizzBuzz.Print(number);

            Assert.Equal(expected, result);
        }

    }
}