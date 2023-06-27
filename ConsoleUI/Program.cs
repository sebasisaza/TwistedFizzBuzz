using TwistedFizzBuzz;

var defaultTokens = new Dictionary<int, string>
{
    { 3, "Fizz" },
    { 5, "Buzz" },
};

int[] numbers = { -20, 127 };

TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzz(numbers, defaultTokens);

Console.WriteLine("----------------------------------");

var tokens = new Dictionary<int, string>
{
    { 5, "Fizz" },
};

TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzz(numbers, tokens);

Console.WriteLine("----------------------------------");

tokens = new Dictionary<int, string>
{
    { 9, "Buzz" },
};

TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzz(numbers, tokens);

Console.WriteLine("----------------------------------");

tokens = new Dictionary<int, string>
{
    { 27, "Bar" },
};

TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzz(numbers, tokens);

Console.WriteLine("----------------------------------");

tokens = new Dictionary<int, string>
{
    { 5, "Fizz" },
    { 9, "Buzz" },
    { 27, "Bar" }
};

TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzz(numbers, tokens);