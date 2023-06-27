using TwistedFizzBuzz;

namespace TestProject1
{
    [TestFixture]
    class NonSequential
    {
        [TestCase]
        public void NonSequentialFizzBuzz()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 8, 100 };
            var tokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
            };

            var res = NonSequentialTwistedFizzBuzz.NonSequential(numbers, tokens);
            Assert.AreEqual(8, res.Count());

            Assert.AreEqual(true, res.Contains("Fizz"));
        }
    }
}