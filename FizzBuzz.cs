using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    /*
    ### The FizzBuzz Kata
	    - Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz"
	      instead of the stringNumber and for the multiples of five print "Buzz". For numbers which are multiples of both
	      three and five print "FizzBuzz".

    ### Including new implementation to The FizzBuzz Kata
	    - Added a different implementation for FizzBuzz using Reactive extensions.
	    - The changes are described at: http://blog.drorhelper.com/2015/02/fizzbuzz-tdd-kata-using-reactive.html
	    - Pull Request by: https://github.com/dhelper (manually merged by @garora)
	      

    #### Steps:

	    Lets divide this into different steps so, we can easily write and test this.
	    - Print numbers from 1 to 100
	    - Print "Fizz" instead of stringNumber which is divisible by 3
	    - Print "Buzz" instead of stringNumber which is divisible by 5
	    - Print "FizzBuzz" instead of stringNumber which is divisible by both 3 and 5

    #### Make more test for accept numbers and provide results
	    - Create a method to accept single stringNumber
	    - Create test to verify supplied stringNumber within the range 1 to 100
	    - Create test to verify stringNumber and return result Fizz or Buzz or FizzBuzz per above criteria
     */
    public class FizzBuzz
    {
        public string Print(string stringNumber)
        {
            int number = int.Parse(stringNumber);

            if (number % 3 == 0 && number % 5 == 0)
            {
                return "fizzbuzz";
            }

            if (number % 5 == 0)
            {
                return "buzz";
            }

            if (number %3 == 0)
            {
                return "fizz";
            }
            return stringNumber;
        }
    }
}
