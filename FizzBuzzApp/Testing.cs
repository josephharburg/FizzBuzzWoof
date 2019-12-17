using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApp
{
    public class Testing
    {
        public string Fizz { get; set; }
        public string Buzz { get; set; }
        public string Woof { get; set; }

        public string FizzBuzz { get; set; }
        public string FizzBuzzWoof { get; set; }
        public Testing() { 
        }
        public void FizzBuzzMethod(string testString)
        {
            
            if ( int.Parse(testString) % 3 == 0 || testString.Contains('3'))
            {
                Fizz = "Fizz";
            }

            if(int.Parse(testString) % 5 == 0 || testString.Contains('5'))
            {
                Buzz = "Buzz";
            }

            if (int.Parse(testString) % 7 == 0 || testString.Contains('7'))
            {
                Woof = "Woof";
            }

            if(Fizz == "Fizz" && Buzz == "Buzz")
            {
                FizzBuzz = "FizzBuzz";
            }

            if(Fizz == "Fizz" && Woof == "Woof")
            {
                FizzBuzz = "FizzWoof";
            }

            if (Buzz == "Buzz" && Woof == "Woof")
            {
                FizzBuzz = "BuzzWoof";
            }

            if(Fizz == "Fizz" && Buzz == "Buzz" && Woof == "Woof")
            {
                FizzBuzzWoof = "FizzBuzzWoof";
            }
        }
    }
}
