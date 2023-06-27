using TwistedFizzBuzz;

namespace TestProject1
{
    [TestFixture]
    class Range
    {
        [TestCase]
        public void RangeFizzBuzz()
        {
            int[] numbers = { 1, 2 };
            var tokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
            };

            var res = RangeTwistedFizzBuzz.Range(numbers, tokens);
            Assert.AreEqual(2, res.Count());

        }
    }
}