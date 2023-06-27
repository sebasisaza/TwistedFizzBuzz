using TwistedFizzBuzz;

var defaultTokens = new Dictionary<int, string>
{
    { 3, "Fizz" },
    { 5, "Buzz" },
};

int[] numbers = { 1, 100 };

TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzz(numbers, defaultTokens, true);