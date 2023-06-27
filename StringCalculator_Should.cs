namespace UnitTest
{
    public class StringCalculator_Should
    {
        [Fact]
        public void Return_Zero_When_Empty_String()
        {
            var calculator = new StringCalculator();
            string s;
            var result = calculator.Add("");

            Assert.Equal(0, result);
        }
    }

    
}